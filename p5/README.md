Este archivo `README.md` debe estar en la raíz de la carpeta abierta en Visual Studio Code; en caso contrario deben usar el comando **File|Open Folder...** para abrir la carpeta que lo contiene.

En este problema deben demostrar que conocen el patrón Polymorphism Sean las siguientes tarjetas CRC de las clases `ResidueType` y `Residue`:

<table id="card">
    <tr>
        <td align="center" colspan="2">
            <p><b>ResidueType</b></p>
        </td>
    </tr>
    <tr>
        <td>
            <p>Conocer el nombre del tipo de residuo</p>
            <p>Conocer si el tipo de residuo es orgánico o no</p>
        </td>
        <td>
            <p>ResidueType</p>
        </td>
    </tr>
</table>


<table id="card">
    <tr>
        <td align="center" colspan="2">
            <p><b>Residue</b></p>
        </td>
    </tr>
    <tr>
        <td>
            <p>Conocer el nombre del residuo</p>
            <p>Conocer el tipo del residuo</p>
            <p>Determinar si dos residuos son iguales</p>
        </td>
        <td>
            <p>ResidueType</p>
        </td>
    </tr>
</table>

💡 Dos residuos son iguales si tienen el mismo `ResidueType` y el mismo valor en la propiedad `Name` con la que se implementa la responsabilidad de conocer el nombre del residuo.

**Consigna:**

Dadas estas tarjetas CRC y el código correspondiente en las carpetas `src` y `test`, completar el código que falta para:

1. Analizar si la operación que determinar si dos objetos son iguales es correcta o no
2. Que pasen todos los casos de prueba provistos

⚠️ No deben modificar los casos de prueba.
