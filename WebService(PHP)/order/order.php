<?php
	
// 訂單service
class Order{

	
	function __construct(){

	}
	
	// 搜尋已繳費及未完成之訂單info帳號未使用及以驗證 (返回單一筆)
	function SearchNotUse(){
		global $db;
		
		try{
			$sql = " SELECT * FROM `order` WHERE `isTrade` = 1 AND `IsComplete` = 0 AND `PaymentDate` != '' ORDER BY TradeDate DESC, id DESC ";
			//$sql = " SELECT * FROM `order` WHERE 1=1 ORDER BY TradeDate DESC, id DESC ";
			$sth = $db -> MySelect($sql);
			$order = $sth -> fetch(PDO::FETCH_ASSOC);
			$rowcount = $sth -> rowCount();
			
			if( $rowcount <= 0 ){
				throw new Exception("沒有任何訂單");
			}
			
			$sql = " SELECT * FROM `order_info` WHERE `order_id` = '".$order['id']."' AND `isUse` = 0 AND `IsCheck` = 1 ";
			//$sql = " SELECT * FROM `order_info` WHERE `order_id` = '".$order['id']."' AND `isUse` = 0 AND `IsCheck` = 0 ";
			$sth = $db -> MySelect($sql);
			$row = $sth -> fetch(PDO::FETCH_ASSOC);
			$rowcount = $sth -> rowCount();
			
			if( $rowcount <= 0 ){
				throw new Exception("該訂單無任何帳號可以run");
			}
			
			// 更新訂單使用帳號狀態
			$this -> ChangeOrderInfoStatus($row['id'], 0, 1, 0);
			
			$output = array(
				"Data" => json_encode($row),
				"success" => true,
				"message" => ""
			);
			
			return $output;
			
		}catch(Exception $e){

			$output = array(
			
				"Data" => "",
				"success" => false,
				"message" => htmlspecialchars($e -> getMessage())
			);
			
			return $output;
		}
	}
	
	// 改變指定訂單的狀態(使用及現在單字量)
	function ChangeOrderInfoStatus($id, $NowEnCount, $status, $IsCheck = 0){
		global $db;
		
		try{
			
			$input = array();
			$table = "order_info";
			$where = " WHERE id = :id ";
			
			$input['id'] 			= $id;
			if(!empty($NowEnCount)){
				$input['NowEnCount'] 	= $NowEnCount; 
			}
			$input['IsCheck']		= $IsCheck;
			$input['isUse'] 		= $status;
			
			$sth = $db -> MyUpdate($table, $input, $where);
			$rowcount = $sth -> rowCount();
			
			$output = array(
				"success" => true,
				"message" => ""
			);
			
			return $output;
			
		}catch(Exception $e){

			$output = array(
				"success" => false,
				"message" => htmlspecialchars($e -> getMessage())
			);
			
			return $output;
		}
	}
	
	// 訂單log記錄
	function LogSave($order_id, $message){
		global $db;
		
		try{
			
			$input = array();
			$table = "order_log";

			$input['order_id'] 	= $order_id;
			$input['message']	= $message;
			
			$sth = $db -> MyInsert($table, $input);
			
			$LastInsertId = $db -> lastinsertid();
			
			if(empty($LastInsertId)){
				throw new Exception("log記錄失敗。");
			}
				
			$output = array(
				"success" => true,
				"message" => ""
			);
			
			return $output;
			
		}catch(Exception $e){

			$output = array(
				"success" => false,
				"message" => htmlspecialchars($e -> getMessage())
			);
			
			return $output;
		}
	}
	
	function AddOrderInfo($nfu_acc, $nfu_pass, $startEnCount, $Subtotal){
		// .NET新增訂單專用(開放永遠使用order_id = 1)
		global $db;
		
		try{
			
			$input = array();
			$table = "order_info";

			$input['order_id'] 		= 1;
			$input['nfuAccount']		= $nfu_acc;
			$input['nfuPassword']		= $nfu_pass;
			$input['startEnCount']	= $startEnCount;
			$input['NowEnCount']	= $startEnCount;
			$input['Subtotal']		= $Subtotal;
			$input['isUse']			= 0;
			$input['IsCheck']		= 0; //驗證收錢
			
			$sth = $db -> MyInsert($table, $input);
			
			$LastInsertId = $db -> lastinsertid();
			
			if(empty($LastInsertId)){
				throw new Exception("訂單新增失敗");
			}
				
			$output = array(
				"success" => true,
				"message" => "新增成功！"
			);
			
			return $output;
			
		}catch(Exception $e){

			$output = array(
				"success" => false,
				"message" => htmlspecialchars($e -> getMessage())
			);
			
			return $output;
		}
	}
	
	function SearchOrderInfo(){
		// .NET搜尋專用，order_id = 1
		global $db;
		
		try{				
			$sql = " SELECT * FROM `order_info` WHERE `order_id` = 1 ";
			$sth = $db -> MySelect($sql);
			$row = $sth -> fetchAll(PDO::FETCH_ASSOC);
			
			$output = array(
				"success" 		=> true,
				"OrderInfoData" => json_encode($row),
				"message" 		=> ""
			);
			
			return $output;
		}catch(Exception $e){

			$output = array(
				"success" 		=> false,
				"OrderInfoData" => "",
				"message" 		=> htmlspecialchars($e -> getMessage())
			);
			
			return $output;
		}
	}	
}

// 搜尋已繳費及未完成之訂單info帳號未使用及以驗證 (返回單一筆)
$server->register(
    'Order.SearchNotUse',
    array(), // input
    array(
		//'Data'=>'tns:OrderSearchNotUse',
		'Data'		=> 'xsd:string',
		'success'	=> 'xsd:boolean',
		'message'	=> 'xsd:string'
	), // output (應使用定義欄位)
	//array('return'=>'xsd:string'), //output
    "urn:Order.SearchNotUse",
    false,
    'rpc',
    false,
    '搜尋已繳費及未完成之訂單info帳號未使用及以驗證 (返回單一筆)'
);

// 改變指定訂單的狀態(使用及現在單字量)
$server->register(
    'Order.ChangeOrderInfoStatus',
    array(
		'id' 			=> 'xsd:int',
		'NowEnCount' 	=> 'xsd:int',
		'status' 		=> 'xsd:int',
		'IsCheck'		=> 'xsd:int'
	), 
    array(
		'success'	=> 'xsd:boolean',
		'message'	=> 'xsd:string'
	), // output (應使用定義欄位)
	//array('return'=>'xsd:string'), //output
    "urn:Order.ChangeOrderInfoStatus",
    false,
    'rpc',
    false,
    '改變指定訂單的狀態(使用及現在單字量)'
);

// 訂單log記錄
$server->register(
    'Order.LogSave',
    array(
		'order_id' => 'xsd:int',
		'message'  => 'xsd:string'
	), // input
    array(
		'success'	=> 'xsd:boolean',
		'message'	=> 'xsd:string'
	), // output (應使用定義欄位)
	//array('return'=>'xsd:string'), //output
    "urn:Order.LogSave",
    false,
    'rpc',
    false,
    '訂單log記錄'
);

// .NET新增訂單專用
$server->register(
    'Order.AddOrderInfo',
    array(
		'nfuAccount' 		=> 'xsd:string',
		'AddOrderInfo'  	=> 'xsd:string',
		'startEnCount'  => 'xsd:int',
		'Subtotal'		=> 'xsd:int'
	), // input
    array(
		'success'	=> 'xsd:boolean',
		'message'	=> 'xsd:string'
	), // output (應使用定義欄位)
	//array('return'=>'xsd:string'), //output
    "urn:Order.AddOrderInfo",
    false,
    'rpc',
    false,
    '.NET新增訂單專用'
);

// .NET搜尋專用
$server->register(
    'Order.SearchOrderInfo',
    array(), // input
    array(
		'success'		=> 'xsd:boolean',
		'OrderInfoData' => 'xsd:string',
		'message'		=> 'xsd:string',
	), // output (應使用定義欄位)
	//array('return'=>'xsd:string'), //output
    "urn:Order.SearchOrderInfo",
    false,
    'rpc',
    false,
    '.NET搜尋專用'
);






$server->wsdl->addComplexType(
				"ArrayOfString",
                "complexType",
                "array",
                "",
                "SOAP-ENC:Array",
                array(),
                array(array("ref"=>"SOAP-ENC:arrayType","wsdl:arrayType"=>"xsd:string[]")),
                "xsd:string"
);


// output param(array) type set
$server->wsdl->addComplexType(
    'OrderSearchNotUse',
    'complexType',
    'struct',
    'all',
    '',
    array(
		'id' => array('name'=>'id','type'=>'xsd:int'),
        'nfu_acc' => array('name'=>'nfu_acc','type'=>'xsd:string'),
        'nfu_pass' => array('name'=>'nfu_pass','type'=>'xsd:string')
    )
);

// 定義輸出
/*
$server->wsdl->addComplexType(
    'MySoapObjectArray',
    'complexType',
    'array',
    '',
    'SOAP-ENC:Array', // 在C#引用必須填寫 , 如給php的webservice client則可以為空
    array(),
    array(
		array(
			'ref'=>'SOAP-ENC:arrayType',
			'wsdl:arrayType'=>'tns:MySoapObject2[]' //參照定義欄位
		)
	),
    'tns:MySoapObject2'
);
*/
?>