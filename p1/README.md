Este archivo `README.md` debe estar en la raíz de la carpeta abierta en Visual Studio Code; en caso contrario deben usar el comando **File|Open Folder...** para abrir la carpeta que lo contiene.

En este problema deben demostrar que saben cómo implementar responsabilidades de conocer a partir de tarjetas CRC.

Sean las siguientes tarjetas CRC de las clases `ResidueType` y `Residue`:

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
            <p>Conocer el nombre del Residuo</p>
            <p>Conocer el tipo del Residuo</p>
            <p>Conocer si el Residuo es orgánico o no</p>
        </td>
        <td>
            <p>ResidueType</p>
        </td>
    </tr>
</table>

💡 El residuo es orgánico si el tipo de residuo es orgánico.

**Consigna:**

Dadas estas tarjetas CRC y el código correspondiente en las carpetas `src` y `test`, completar el código que falta para:

1. Representar en C# las responsabilidades de esas tarjetas CRC
2. Que pasen todos los casos de prueba provistos

⚠️ No deben modificar los casos de prueba.

💡 El código que falta está en la clase `Residuo`.
