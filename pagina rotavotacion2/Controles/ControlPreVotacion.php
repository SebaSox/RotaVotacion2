<?php
    session_start();
	$controlar= $_SESSION['usuario'];
	if ($controlar == null || $controlar == "") {
		header("Location:index.php");
	}

    include 'ConexionSQL.php';
    //consultar si ya voto
    $Consulta= "SELECT C.Id as Clubes, R.Id as respuestas, M.Id as mociones, R.Voto
    FROM [dbo].[Respuestas] R
    JOIN [dbo].[Clubes] C
    ON R.IdClub = C.Id
    JOIN [dbo].[Mocion] M
    ON R.IdMocion = M.Id
    WHERE M.Id = (SELECT MAX(Id) FROM Mocion) AND C.Id = '$controlar'";

    $Resultado= sqlsrv_query($Con, $Consulta, array(), array( "Scrollable" => SQLSRV_CURSOR_KEYSET ));

    $row_count = sqlsrv_num_rows( $Resultado );

    if ($row_count ==0){
        header("Location:../Votacion.php");
    }else{
        $_SESSION['Fallo']= "El club ya voto en esta mocion";
        header("Location:../Errores.php");
    }

?>