<?php   
    session_start();
    include 'ConexionSQL.php';
    $NomClub= $_POST['NomClub'];
    $Consulta= "SELECT [Id],[NombreClub],[EstadoReunion],[EstadoGeneral]FROM [dbo].[Clubes]WHERE NombreClub ='$NomClub'";
    $Resultado= sqlsrv_query($Con, $Consulta, array(), array( "Scrollable" => SQLSRV_CURSOR_KEYSET ));

    $row_count = sqlsrv_num_rows( $Resultado );

    if ($row_count ==0){
        $_SESSION['Fallo']= "El nombre no figura en nuestras bases de datos, revisar si esta bien escrito 
        o llamar a la persona de IT mas cercana)";
        header("Location:../Errores.php");
    }
    while( $row = sqlsrv_fetch_array( $Resultado, SQLSRV_FETCH_ASSOC) ) {
        
        if ($row['EstadoGeneral'] =="0") {
            $_SESSION['Fallo']= "Tu club no esta activado a nivel general (llamar a la persona de IT mas cercana)";
            header("Location:../Errores.php");
        }else {
            if ($row['EstadoReunion'] =="0") {
                $_SESSION['Fallo']= "Tu club no esta activo para votar en esta reunion (avisarle a secretario o a IT)";
                header("Location:../Errores.php");
            } else {
                
                $_SESSION['usuario']=$row['Id'];
                header("Location:../Espera.php");
            }           
        }   
    }
?>