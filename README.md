# FLEET MANAGEMENT

## �ndice


* [1. Resumen del proyecto](#2-resumen-del-proyecto)
* [2. Herramientas](#3-herramientas)
* [3. Historias de usuario](#4-historias-de-usuario)
* [4. Prototipos](#5-prototipos)
* [5. Planificaci�n del proyecto](#6-planificacion-del-proyecto)
* [6. Resultado](#7-resultado)



## 1. Resumen del proyecto

En este proyecto se contruy� la API REST de un Fleet Management Software para consultar las ubicaciones de los veh�culos de una empresa de taxis en Beijing, China.

Con las ubicaciones de casi 10 mil taxis. Se aplicaron t�cnicas para almacenar y consultar esta informaci�n, usando PostgreSQL.

Se decoumento los endpoints de la API en Swagger.

## 3. Herramientas
### Uso de lenguaje C#
Se cre� un proyecto Web API en C# con la plantilla "API con controladores", tambi�n se us� Entity Framework, un ORM que simplifica el acceso y manipulaci�n de bases de datos.  

### Modelamiento de datos
Se us� vercel Postgresql, se cre� tablas en la base de datos para almacenar la informaci�n entregada. Te recomendamos entonces crear dos tablas, una para almacenar la informaci�n de taxis y otra para almacenar la informaci�n de ubicaciones. Deber�s definir las columnas de cada tabla de acuerdo a la informaci�n entregada.

### Definir endpoints de API
Se defini� y documento los endpoints de la APIen Swagger.

Para una API REST debes definir para cada endpoint entre otras cosas el m�todo HTTP, url, par�metros, encabezados, c�digos HTTP de respuesta y cuerpo.
## 4. Historias de Usuario

#### [Historia de usuario 1] Cargar informaci�n a base de datos

Yo, como desarrolladora, quiero cargar la informaci�n almacenada hasta ahora en
[archivos sql](https://drive.google.com/file/d/1T5m6Vzl9hbD75E9fGnjbOiG2UYINSmLx/view?usp=drive_link)
en una base de datos PostgreSQL, para facilitar su consulta y an�lisis.

##### Criterios de aceptaci�n

* Se debe tener en cuenta el siguiente diagrama para la implementaci�n de las
relaciones entre las tablas

![mer](https://firebasestorage.googleapis.com/v0/b/laboratoria-945ea.appspot.com/o/fleet-management-api-java%2Fsql-diagram.png?alt=media)

* La tabla de _trajectories_ se debe crear con el "id" que se incremente
autom�ticamente (SERIAL) para poder insertar los valores sin necesidad
de especificar un identificador

##### Definici�n de terminado

* La base de datos tiene creada la tabla de taxis
* La tabla de taxis tiene cargada la data de taxis
* La base de datos tiene creada la tabla de trayectorias
* La tabla de taxis tiene cargada la data de trayectorias

***

##### [Historia de usuario 2] Endpoint listado de taxis

Yo como clienta de la API REST requiero un _endpoint_ para
listar todos los taxis.

##### Criterios de aceptaci�n

* El _endpoint_ responde para cada taxi: id y placa.
* El _endpoint_ paginamos los resultados para asegurar que las
respuestas sean m�s f�ciles de manejar.

##### Definici�n de terminado

* Se cuenta con una documentaci�n en [Swagger](https://swagger.io/)
para el _endpoint_ desarrollado especificando
[m�todo HTTP](https://developer.mozilla.org/en-US/docs/Web/HTTP/Methods),
url, par�metros,
[encabezados](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers),
[c�digos HTTP de respuesta](https://shorturl.at/bdegB)
y
[cuerpo](https://developer.mozilla.org/en-US/docs/Web/HTTP/Messages).
* El c�digo del _endpoint_ debe recibir _code review_ de al
menos una compa�era.
* El c�digo _endpoint_ debe estar cargado en un repositorio de Github.
* El c�digo _endpoint_ debe contar con test unitarios y e2e.

***

#### [Historia de usuario 3] Endpoint historial de ubicaciones

Yo como clienta de la API REST requiero un _endpoint_ para
consultar todas las ubicaciones de un taxi dado el id y una fecha.

##### Criterios de aceptaci�n

* El _endpoint_ responde con el id del taxi y una fecha mostrando
  la siguiente informaci�n: latitud, longitud y timestamp (fecha y hora).
* El _endpoint_ paginamos los resultados para asegurar que las
  respuestas sean m�s f�ciles de manejar.

##### Definici�n de terminado

* Se cuenta con una documentaci�n en [Swagger](https://swagger.io/)
para el _endpoint_ desarrollado especificando
[m�todo HTTP](https://developer.mozilla.org/en-US/docs/Web/HTTP/Methods),
url, par�metros,
[encabezados](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers),
[c�digos HTTP de respuesta](https://shorturl.at/bdegB)
y
[cuerpo](https://developer.mozilla.org/en-US/docs/Web/HTTP/Messages).
* El c�digo del _endpoint_ debe recibir _code review_ de al
menos una compa�era.
* El c�digo _endpoint_ debe estar cargado en un repositorio de Github.
* El c�digo _endpoint_ debe contar con test unitarios y e2e.

***

#### [Historia de usuario 4] Endpoint �ltima ubicaci�n

Yo como clienta de la API REST requiero un _endpoint_ para
consultar la �ltima ubicaci�n reportada por cada taxi.

##### Criterios de aceptaci�n

* El _endpoint_ responde para cada taxi la siguiente informaci�n:
id, placa, latitud, longitud y timestamp (fecha y hora).
* El _endpoint_ paginamos los resultados para asegurar que las
respuestas sean m�s f�ciles de manejar.

##### Definici�n de terminado

* Se cuenta con una documentaci�n en [Swagger](https://swagger.io/)
para el _endpoint_ desarrollado especificando
[m�todo HTTP](https://developer.mozilla.org/en-US/docs/Web/HTTP/Methods),
url, par�metros,
[encabezados](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers),
[c�digos HTTP de respuesta](https://shorturl.at/bdegB)
y
[cuerpo](https://developer.mozilla.org/en-US/docs/Web/HTTP/Messages).
* El c�digo del _endpoint_ debe recibir _code review_ de al
menos una compa�era.
* El c�digo _endpoint_ debe estar cargado en un repositorio de Github.
* El c�digo _endpoint_ debe contar con test unitarios y e2e.

***

### Testing

El proyecto cuenta con tests para cada controlador Taxis y Trajectories

## 6. Planificaci�n del proyecto

Me planifiqu� en Git Hub projects, este me ayudo a optimizar mi proceso y hacerle seguimiento a mi avance diario.

## 7. Resultado
![result 1](assets/resultado1.png)
![result 2](assets/resultado2.png)
![result 3](assets/resultado3.png)