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
    <link rel="stylesheet" type="text/css" href="Estilos/Final.css">
    <title>RotaVotacion2</title>
</head>
<body>
    <div class="Contenedor">
        <div class="card">
            <h1 class="card__title">Gracias por tu voto!</h1>
            <p class="card__content">Ahora toca esperar la proxima votacion! <br>   
                Podes apretar el boton de abajo para volver al inicio y esperar. 
            </p>
            <form action="Espera.php">
            <div class="card__form">
                <button class="sign-up"> Vamos al inicio</button>
            </div>
            </form>
        </div>
    </div>
</body>
</html>