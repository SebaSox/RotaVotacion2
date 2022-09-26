<?php
    $ServerName= "localhost";
    $InfoDeConexion= array ("Database"=>"RotaVotacion", "UID"=>"rotavotacion", "PWD"=>"soporteit", "CharacterSet"=>"UTF-8");
    $Con = sqlsrv_connect($ServerName, $InfoDeConexion);
    if ($Con) {    
    } else {
        session_start();
        $_SESSION['Fallo']= "Fallo al conectar la base de datos comunicarse con el area de IT";
        header("Location:../Errores.php");   
		die( print_r( sqlsrv_errors(), true));
    }
    


?>