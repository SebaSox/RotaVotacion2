<?php  
	session_start();
	$controlar= $_SESSION['usuario'];
	if ($controlar == null || $controlar == "") {
		header("Location:index.php");
	}
?>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" type="text/css" href="Estilos/Principal.css">
    <title>RotaVotacion2</title>
</head>
<body>
    <div class="Contenedor">
        <div class="card">
            <h1 class="card__title">RotaVotacion2</h1>
            <p class="card__content">La funcionalidad de la aplicacion es muy sencilla cuando el/la Secretario/a distrital avise que pueden votar precionas el boton de abajo. luego seleccionas la opcion que quieres votar y listo! 
            </p>
            <div class="card__form">
                <form action="Controles/ControlPreVotacion.php" method="post">
                <button class="sign-up"> Estoy listo para votar</button>
                </form>
            </div>
        </div>
    </div>
</body>
</html>