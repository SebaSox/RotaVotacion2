<?php
    session_start();
	$controlar= $_SESSION['usuario'];
	if ($controlar == null || $controlar == "") {
		header("Location:index.php");
	}
    $Voto = $_POST['Voto'];
    $IdMo = (int)$_POST['IdMo'];
    include 'ConexionSQL.php';
    $Consulta= "INSERT INTO [dbo].[Respuestas]([IdClub],[IdMocion],[Voto])VALUES('$controlar', $IdMo, '$Voto')";

    $Preparado=sqlsrv_prepare($Con, $Consulta);

    if (sqlsrv_execute($Preparado)) {
        header("Location:../Final.php");
    } else {
        echo"Hey un error  <br>";
        die( print_r( sqlsrv_errors(), true)); 
    }
    






?>