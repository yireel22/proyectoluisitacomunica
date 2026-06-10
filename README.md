```markdown
# 📱 proyectoluisitacomunica — App de Monitoreo de Salud

Una aplicación móvil multiplataforma moderna y minimalista desarrollada con **.NET MAUI**. El diseño toma como inspiración los tableros avanzados de bienestar físico (*estilo Huawei Salud*), implementando una interfaz limpia en **Modo Oscuro** con análisis reactivo de datos mediante componentes visuales de alto rendimiento.

---

### 🌟 Características Destacadas

* **Tablero Centralizado (Dashboard):** Organización modular basada en tarjetas independientes con bordes suavizados para facilitar la lectura.
* **Interfaz Ultra-Dark:** Paleta de colores optimizada para reducir la fatiga visual en entornos de baja iluminación.
* **Gráficos Circulares Dinámicos:** Integración de un motor de renderizado de anillos concéntricos (*Radial Gauge Chart*) para medir los tres pilares del día: **Movimiento**, **Ejercicio** y **De pie**.
* **Métricas en Tiempo Real:** Componentes táctiles interactivos que comunican la pantalla principal con flujos de trabajo detallados.
* **Simulador Reactivo:** Botón integrado para emular el conteo de pasos incrementales con actualización instantánea de la UI.

---

### 🛠️ Arquitectura y Tecnologías

El desarrollo se construyó utilizando herramientas nativas del ecosistema de Microsoft y componentes gráficos optimizados:

* **Framework Base:** `.NET MAUI` (orientado a .NET 8.0 / 9.0).
* **Motor de Gráficos:** `Microcharts.Maui` para la gestión de datos visuales.
* **Biblioteca de Renderizado:** `SkiaSharp` encargado del dibujo en alta fidelidad.
* **Paradigma de Diseño:** Combinación declarativa de `XAML` y lógica imperativa en `C#`.

---

### 📦 Configuración y Dependencias

#### 1. Estructura del Espacio de Nombres
Para garantizar que los enlaces internos de la aplicación funcionen de manera correcta, la solución y el proyecto deben estar nombrados exactamente bajo el identificador:
```text
proyectoluisitacomunica

```

#### 2. Inyección del Paquete de Gráficos

Antes de realizar la primera compilación, es mandatorio instalar el componente de gráficos. Abre la **Consola del Administrador de Paquetes NuGet** (*Herramientas > Administrador de Paquetes NuGet > Consola del Administrador de Paquetes*) y ejecuta:

```bash
Install-Package Microcharts.Maui

```

---

### 📂 Organización del Código

El núcleo lógico y de interfaz se concentra en los siguientes archivos clave dentro de la estructura de la solución:

* 📄 **`MauiProgram.cs`** *Punto de inicialización global.* Registra la aplicación y activa el uso del paquete de gráficos mediante el método `.UseMicrocharts()`.
* 📄 **`App.xaml.cs`** *Controlador de arranque.* Envuelve la interfaz en un contenedor `NavigationPage` para dar soporte nativo al intercambio dinámico de pantallas.
* 📄 **`MainPage.xaml` / `MainPage.xaml.cs**` *Tablero principal.* Define la estructura visual del Dashboard, inicializa los valores de los anillos concéntricos y gestiona los gestos de toque de las métricas.
* 📄 **`DetalleMetricaPage.xaml` / `DetalleMetricaPage.xaml.cs**` *Pantalla de gestión.* Recibe parámetros dinámicos de color y tipo de métrica para mutar la interfaz según la tarjeta origen (Corazón, Sueño, SpO2, Peso).

---

### 🧪 Validación y Despliegue

1. Abre la solución en **Visual Studio**.
2. En la barra de herramientas superior, selecciona el entorno objetivo deseado:
* **Máquina de Windows:** Despliegue rápido en escritorio para validar flujos lógicos.
* **Emulador de Android:** Validación de experiencia de usuario en formato nativo de teléfono móvil.


3. Inicia la ejecución presionando la tecla **`F5`** o haciendo clic sobre el botón **Play**.

```

```
