# SAMPLES DTE

SAMPLES-DTE es una solución Visual Studio, que pretende ejemplificar, la mayor cantidad de las operaciones disponibles en [SIMPLE API](http://www.simple-api.cl). Este utilitario, muestra como operar todos los pasos que se componen en la emisión de los documentos (DTE) y otros varios, como el IECV, Libro de boletas, RCOF, entre otros.

[SIMPLE API](http://www.simple-api.cl) viene con la conexión incorporada al SII para el envío de los documentos.

## Comenzando 🚀

Para utilizar *SIMPLE API*, es necesario contar con un código de activación tipo Serial Key. La que viene incluída en el archivo Handler.cs, tiene una duración limitada y cuenta con un tope de 100 documentos. **Pero servirá para que la pruebes ;)**

Más información en [www.simple-api.cl](http://www.simple-api.cl) o solicitandola a contacto@chilesystems.com

### Pre-requisitos 📋

```
.NET Framework 4.6
Certificado Digital
SIMPLE API
```
### Instalación 🔧

1. Dentro de la carpeta donde correrá el proyecto (Debug o Release según corresponda en el caso del entorno de VS), debes tener la siguiente estructura de carpetas:

* out
* XML (El contenido de esta carpeta, lo puedes descargar desde [aquí](http://www.chilesystems.com/SDK/XML.rar))
* itextsharp 5.5.9.0 (Este DLL lo puedes descargar desde [aquí](http://www.chilesystems.com/SDK/itextsharp.dll)) 

Dentro de **out** las carpetas
 * caf
 * temp

En la carpeta _temp_ se guardarán los archivos XML. En la carpeta _caf_ los códigos de autorización de folios que entrega el SII. **Estas rutas son alternativas**.

2. Debes agregar la referencia a [SIMPLE API](http://www.simple-api.cl/Descarga) y la de [itextsharp](http://www.chilesystems.com/SDK/itextsharp.dll)  a tu proyecto.

3. Reemplaza los valores que están en Handler.cs por los que corresponden a la empresa en cuestión.

4. Instala tu certificado digital. Debes buscar su nombre descriptivo o "Friendly Name" y reemplazar ese valor en la clase Handler.cs

4. Descarga un código de autorización de folios (CAF) desde el [SII](http://www.sii.cl)

### Apoyo externo 🔩

En 4 videos, se muestra cómo utilizar este mismo proyecto (el de los videos es un poco más antiguo, pero las variaciones son mínimas).

* [Simulación y generación de Timbre impreso de DTE con API Simple](https://www.youtube.com/watch?v=ZLRxZ58b-w4)
* [Generación y envío de DTE al SII Chile con Simple API](https://www.youtube.com/watch?v=q20kf8eke50)
* [Certificación DTE de boletas electrónicas con Simple API](https://www.youtube.com/watch?v=gq5mBIAyf6o)
* [Certificacion DTE set de pruebas SII Chile con Simple API](https://www.youtube.com/watch?v=m_udVOpiP6M)


