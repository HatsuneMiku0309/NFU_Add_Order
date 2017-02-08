<?php
header("Content-Type:text/html;charset=utf-8;");
require_once("./nusoap-0.9.5/lib/nusoap.php");
$url = $_SERVER['REQUEST_SCHEME']."://".$_SERVER['HTTP_HOST']."/AdminLTE-2.3.0/pages/webservice/service.php?wsdl";
$client = new nusoap_client($url);
$client->soap_defencoding = 'utf-8';
$client->decode_utf8 = false;
$client->xml_encoding = 'utf-8';
$err = $client->getError();
if ($err){
	
	echo  " 调用出错： " . $err ; 
    return false;

}
// 依照 value 為第一參數、第二參數  (key 只做為參考)
/*
$param = array( 'test', '你是誰' );
//$param = array( "name2" => 'test2' );
$result = $client->call('gethelloworld', $param);
*/


// input 陣列 output 陣列
/*
$param = array(
	0 => array(
		"Author2" => "test0",
		"Description2" => "test1",
		"Name2" => "test2",
		"Text2" => "test3",
		"VoteCount2" => 1,
		"VoteTotal2" => 2,
		"gg2" => 3
	)
);
$result = $client->call('ProcessMySoapObject', array($param));
*/

// call class_function

$param = array( '40223243','40223243' );
$result = $client->call('Order.SearchNotUse', $param);


$err = $client->getError();
if ($client->fault) {
    echo "<h2>Fault</h2><pre>";
    print_r ($result);
    echo "</pre>";
}else{
	if  (! $err = $client->getError()) {  
		/*
		echo  " 返回结果： " . 
			  '<br/> sayHello -- ' . $result ; 
		*/
		print_r($result);
	}else{  
		echo  " 調用出错： " . $err ; 
	}
}




/* 當呼叫的service 是 class function (例: food::getFood)
$proxy = $client->getProxy();
echo $proxy->food__getFood('Main');
*/
?>