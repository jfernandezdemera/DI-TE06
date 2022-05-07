# Dashboard NORTWIND

## Índice 📑
1. [About](#id1)
   1. [Pre-requisitos](#id2)
   2. [Instalación](#id3)
2. [Contacto](#id4)
   1. [Autores](#id5)
   2. [Licencia](#id6)
3. [Refencias](#id7)


<div id='id1' />

## About 🚀

Se trata de un dashboard para explotar la información de la BBDD NORTHWIND de pruebas de Microsoft.

Con él se pueden observar diferentes Querys realizadas contra la BBDD para poder obtener los datos necesarios 
_Estas instrucciones te permitirán obtener una copia del proyecto en funcionamiento en tu máquina local para propósitos de desarrollo y pruebas._

ESTA APLICACIÓN ESTÁ ORIENTARA PARA CUALQUIER USO CON FINES NO COMERCIALES. PODRÁN BENEFICIARSE DE ELLA DOCENTES Y ESTUDIANTES CON FINES EDUCATIVOS.

<div id='id2' />

### Pre-requisitos 📋 

```
Microsoft Visual Studio
```
<div id='id3' />

### Instalación 🔧

La aplicación es posible utilizarla de dos maneras:
> 1. Compilándola y ejecutándola desde el IDE
```
Sera necesario abrir el proyecto en MVS y compilarlo.
```

> 2. Instalándola.

```
Será necesario abrir el proyecto en MVS y compilar el proyecto "installer".

Esto nos generará un instalable que podemos distribuir o instalar en el equipo en el siguiente directorio de la solución.
```

`NORTHWIND\Installer\Release\Installer.msi`
```
Después de arrancar el instalador y completar el Wizard:

```
![Installer 1](/git_images/installer1.PNG "Instalador 1")

![Installer 1](/git_images/installer2.PNG "Instalador 2")

![Installer 1](/git_images/installer3.PNG "Instalador 3")

![Installer 1](/git_images/installer4.PNG "Instalador 4")

<div id='id4' />

## Contacto 📖

Soy Jon Fernández de Mera y soy estudiante de DAM y programador en Grupo Versia (C++).

email - jon.fernandezdemera@gmail.com

<div id='id5' />

### Autores ✒️

* **Jon Fernández de Mera** - *Trabajo Inicial* 
* **Jon Fernández de Mera** - *Documentación*

<div id='id6' />

### Licencia 📄

Este proyecto está bajo la Licencia (Semi-Libre) - mira el archivo [LICENSE.md](LICENSE.md) para más detalles.


<div id='id7' />

## Referencias 📜

Referencias utilizadas para llevar a cabo el proyecto:

* [Microsoft Visual Studio](https://visualstudio.microsoft.com/es/vs/community/?msclkid=0cd89a7ec7d611ec8e050dc43f343aba) - IDE usado
* [SAP Crystal Reports for MVS](https://www.sap.com/products/crystal-visual-studio.html?msclkid=ba948972c7d611eca47649e9bb5a4a04) - Generador de reportes
* [Microsoft SQL Server Reporting Services](https://docs.microsoft.com/en-us/sql/reporting-services/install-windows/install-reporting-services?msclkid=401a86b5c7d611ec91bd43b1e72c91ab&view=sql-server-ver15) - Generador de reportes
* [NORTHWIND BBDD](https://github.com/Microsoft/sql-server-samples/tree/master/samples/databases/northwind-pubs) - Script para generación de la BBDD de pruebas
* [htmlhelp](/external/htmlhelp.exe) - Aplicación para generar documentos de HTML compilado (chtm)
