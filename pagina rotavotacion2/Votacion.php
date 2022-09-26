<?php  
	session_start();
	$controlar= $_SESSION['usuario'];
	if ($controlar == null || $controlar == "") {
		header("Location:index.php");
	}
    include 'Controles/ConexionSQL.php';
    $Consulta= "SELECT [Id], [Mocion] FROM [dbo].[Mocion] WHERE Id = (SELECT MAX(Id) FROM Mocion)";
    $Resultado= sqlsrv_query($Con, $Consulta, array(), array( "Scrollable" => SQLSRV_CURSOR_KEYSET ));
    $row_count = sqlsrv_num_rows( $Resultado );
    if ($row_count ==0){
        die( print( "Hay un problema espere y vuelva a intentar mas tarde"));
    }
    
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" type="text/css" href="Estilos/Principal.css">
    <link rel="stylesheet" type="text/css" href="Estilos/Votacion.css">
    <title>RotaVotacion2</title>
</head>
<body>
    <div class="Contenedor">
        <div class="card">
            <p class="card__content"> <?php   while( $row = sqlsrv_fetch_array( $Resultado, SQLSRV_FETCH_ASSOC) ) { echo $row['Mocion']; $IdMocion= $row['Id'];}   ?>
            </p>
            <form action="Controles/ControlVotacion.php" method="post">
                <div class="card__form">
                    <input type="hidden" name="Voto" value="3">
                    <input type="hidden" name="IdMo" value= "<?php echo $IdMocion;  ?>">
                    <button class="sign-up" id="Positivo"> Positivo</button>
                </div>
            </form>
            <form action="Controles/ControlVotacion.php" method="post"> 
                <div class="card__form">
                    <input type="hidden" name="Voto" value="2">
                    <input type="hidden" name="IdMo" value= "<?php echo $IdMocion;  ?>">
                    <button class="sign-up" id="Abstencion"> Abstencion</button>
                </div>
            </form>
            <form action="Controles/ControlVotacion.php" method="post">
                <div class="card__form">
                    <input type="hidden" name="Voto" value="1">
                    <input type="hidden" name="IdMo" value= "<?php echo $IdMocion;  ?>"">
                    <button class="sign-up" id="Negativo"> Negativo</button>
                </div>
            </form>
        </div>
    </div>
</body>
</html>