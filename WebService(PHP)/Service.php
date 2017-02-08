<?php
header("Content-Type:text/html;charset=utf-8;");
require_once("../../include/utility.php");
require_once("./nusoap-0.9.5/lib/nusoap.php");

$namespace = $_SERVER['REQUEST_SCHEME']."://".$_SERVER['HTTP_HOST'].$_SERVER['REQUEST_URI'];
/*
echo $_SERVER['HTTP_HOST'].$_SERVER['REQUEST_URI'];
var_dump($_SERVER);
*/
$server = new soap_server();
//$server->configureWSDL("concatenate");
// wsdl name
$server -> configureWSDL("SimpleService");
$server -> wsdl -> schemaTargetNamespace = $namespace;
$server -> soap_defencoding = 'UTF-8';
$server -> xml_encoding 	= 'UTF-8'; 
$server -> decode_utf8 		= false;


//註冊服務
$server->register(
	"gethelloworld", // function name
	array( // input param type
		"name" => "xsd:string",
		"name2" => "xsd:string"
	),
	array( // input param type
		"return" => "xsd:string" 
	),
	"urn:helloworld", // namespace
	//$namespace,
	//false,
	"urn:helloworld#gethelloworld" // soap_namespace
);
 
// 實體服務
function gethelloworld($name , $name2) {
	if (is_string($name) && is_string($name2)){
        $myname    =    "My Name Is <b>".$name.", ". $name2 . "</b>";
		/*
		$myname = array(
			"test",
			"test2"
		);
		*/
		return $myname;
    }else{
		//return 'concatenate 函數的參數應該是兩個字符串 ' . $name . ', ' . $name2;
        return new soap_fault(' Clinet ','','concatenate 函數的參數應該是兩個字符串 ');
	}
}



// input 陣列  output 陣列
// output param(array) type set
$server->wsdl->addComplexType(
    'MySoapObject',
    'complexType',
    'struct',
    'all',
    '',
    array(
        'Author' => array('name'=>'Author','type'=>'xsd:string'),
        'Name' => array('name'=>'Name','type'=>'xsd:string'),
        'Description' => array('name'=>'Description','type'=>'xsd:string'),
        'Text' => array('name'=>'Text','type'=>'xsd:string'),
        'VoteTotal' => array('name'=>'VoteTotal','type'=>'xsd:int'),
        'VoteCount' => array('name'=>'VoteCount','type'=>'xsd:int')
    )
);
$server->wsdl->addComplexType(
    'MySoapObject2',
    'complexType',
    'struct',
    'all',
    '',
    array(
        'Author2' => array('name'=>'Author','type'=>'xsd:string'),
        'Name2' => array('name'=>'Name','type'=>'xsd:string'),
        'Description2' => array('name'=>'Description','type'=>'xsd:string'),
        'Text2' => array('name'=>'Text','type'=>'xsd:string'),
        'VoteTotal2' => array('name'=>'VoteTotal','type'=>'xsd:int'),
        'VoteCount2' => array('name'=>'VoteCount','type'=>'xsd:int')
    )
);

// 定義輸出
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
$server->wsdl->addComplexType("ArrayOfString",
                 "complexType",
                 "array",
                 "",
                 "SOAP-ENC:Array",
                 array(),
                 array(array("ref"=>"SOAP-ENC:arrayType","wsdl:arrayType"=>"xsd:string[]")),
                 "xsd:string"
);

function ProcessMySoapObject($mySoapObjects) {
	$mso = $mySoapObjects[0];
	$output = array();
	foreach ( $mso as $key => $value ){
		switch ($key){
			case "Author2":
				$output["Author"] = $key;
				break;
			default:
				$output[substr($key,0,-1)] = $value;
				break;
		}
	}
	//$mso['Name'] = "|||";
	return $output;
}

$server->register(
    'ProcessMySoapObject',
	// array('soapObjects'=>'tns:MySoapObject2'), 	// 錯誤的定義array
    array('soapObjects'=>'tns:MySoapObjectArray'), 	// 輸入的定義(必須另參照欄位)
	// array('return'=>'tns:ArrayOfString'), 		// 定義輸出string[] array (C# 宣告 string[])
    array('return'=>'tns:MySoapObject'), 			// 輸出的欄位定義
    $ns,
    false,
    'rpc',
    false,
    'Processes an array of MySoapObjects and returns one of them'
);

// class_function webservice
class test{
	
	function test1($gg){
		
		return $gg;
		
	}
	
}

$server->register(
    'test.test1',
    array('gg'=>'xsd:string'), // input
    array('return'=>'xsd:string'), // output
	// array('return'=>'xsd:string'), output
    "urn:test.test1",
    false,
    'rpc',
    false,
    'Processes an array of MySoapObjects and returns one of them'
);


// member 服務
require_once "./member/member.php";

// Order 服務
require_once "./order/order.php";

//$HTTP_RAW_POST_DATA = isset($HTTP_RAW_POST_DATA) ? $HTTP_RAW_POST_DATA : '';
$HTTP_RAW_POST_DATA = isset($GLOBALS['HTTP_RAW_POST_DATA']) ? $GLOBALS['HTTP_RAW_POST_DATA'] : '';
$server->service($HTTP_RAW_POST_DATA);
exit();

?>