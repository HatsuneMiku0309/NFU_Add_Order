<?php
	
// 會員service
class member{

	
	function __construct(){

	}
	
	function login($acc, $pass){
		global $db;
	
		$sql = " SELECT * FROM `member` WHERE `acc` = '".$acc."' AND `pass` = '".$pass."' ";
		$sth = $db -> MySelect($sql);
		$row = $sth -> fetch(PDO::FETCH_ASSOC);
		
		return $row;
	}
	
}

$server->register(
    'member.login',
    array(
		'acc'	=> 'xsd:string',
		'pass' 	=> 'xsd:string'
	), // input
    array('return'=>'tns:ArrayOfString'), // output (應使用定義欄位)
	//array('return'=>'xsd:string'), //output
    "urn:member.login",
    false,
    'rpc',
    false,
    'Processes an array of MySoapObjects and returns one of them'
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


// output param(array) type set
/*
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
*/
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
*/
?>