# Plataforma e-Commerce Básica en C#

## 📌 Descripción
Este proyecto consiste en la implementación de clases básicas para una plataforma e-Commerce utilizando Programación Orientada a Objetos en C#. El objetivo principal es modelar los componentes fundamentales de una tienda en línea a través de clases que representen las entidades principales del negocio, tales como Producto, Usuario y Carrito de Compras.

El sistema simula el funcionamiento básico de una plataforma de comercio electrónico en un entorno de aplicación de consola, permitiendo visualizar productos, agregarlos a un carrito de compras y calcular el total de la compra. Aunque se trata de una versión simplificada, el diseño sigue principios fundamentales de la Programación Orientada a Objetos como encapsulamiento, uso de constructores, métodos de acceso (get y set) y separación de responsabilidades por clase.

Cada clase fue diseñada para representar una entidad real del sistema e-Commerce. La clase Producto gestiona la información de los artículos disponibles, incluyendo su identificador, nombre, descripción, precio y stock. La clase Usuario modela la información básica de un cliente, mientras que la clase Carrito permite administrar una colección de productos seleccionados y calcular el total acumulado de la compra.

Este proyecto permite comprender cómo estructurar un sistema basado en objetos, cómo interactúan las clases entre sí y cómo organizar la lógica del negocio en una aplicación modular. Además, sienta las bases para futuras mejoras como integración con bases de datos, interfaces gráficas o implementación web mediante frameworks como ASP.NET.

Se desarrollaron las clases:

- Producto
- Usuario
- Carrito de Compras

El sistema simula el funcionamiento básico de una tienda en línea desde consola.

---

## 🛠 Tecnologías Utilizadas

- C#
- .NET
- Programación Orientada a Objetos
- Visual Studio

---

## 🧱 Implementación

### Clase Producto
Incluye atributos:
- id
- nombre
- descripción
- precio
- stock

Se implementaron métodos GET y SET para encapsular los atributos y un constructor para inicializar objetos.

### Clase Usuario
Incluye:
- id
- nombre
- correo electrónico
- contraseña

Incluye constructor, métodos GET/SET y destructor opcional.

### Clase Carrito
Incluye:
- Lista de productos
- Total del carrito

Métodos implementados:
- AgregarProducto()
- RemoverProducto()
- CalcularTotal()

---
<img width="474" height="215" alt="Captura de pantalla 2026-02-21 153008" src="https://github.com/user-attachments/assets/57e81124-d832-47d4-8911-8a3faa794479" />
<img width="233" height="143" alt="Captura de pantalla 2026-02-21 152958" src="https://github.com/user-attachments/assets/102189b7-a322-44a5-9b1e-f1fe34d11c55" />
<img width="373" height="316" alt="Captura de pantalla 2026-02-21 153035" src="https://github.com/user-attachments/assets/9d18702a-b736-4807-a7e2-118d801d3ff0" />
<img width="218" height="185" alt="Captura de pantalla 2026-02-21 153015" src="https://github.com/user-attachments/assets/5700e9a1-157b-4c3f-a2de-61ad00ffe644" />

## 📷 Capturas



##  Desafíos Enfrentados

Uno de los principales desafíos fue controlar correctamente el stock al agregar y remover productos del carrito. Se solucionó validando el stock antes de agregar el producto y actualizando la cantidad disponible.

---

##  Cómo Ejecutar

1. Clonar el repositorio
2. Abrir en Visual Studio

3. Ejecutar el archivo Program.cs
