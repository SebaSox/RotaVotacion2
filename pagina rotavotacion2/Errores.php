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
            <p class="card__content"><?php session_start(); echo  $_SESSION['Fallo'] ; ?>
            </p>
            <div class="card__form">
                <form action="index.html" method="post">
                <button class="sign-up"> Volver al inicio</button>
                </form>
            </div>
        </div>
    </div>
</body>
</html>