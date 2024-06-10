# 🏯Lost Castle🏯
## José Luis González Álamo DAM

[Wallpaper](./wallpaper.png)


## Índice

1. [Descripción del proyecto](#1-descripción-del-proyecto)
2. [Justificación](#2-justificación)
3. [Objetivos](#3-objetivos)
4. [Motivación](#4-motivación)
5. [Cómo Jugar](#5-cómo-jugar)
6. [Lista de Características](#6-lista-de-características)
7. [Guía de instalación ](#7-guía-de-instalación-)
8. [Guía de uso de Lost Castle](#8-guía-de-uso-de-lost-castle)
9. [Explicación de los Scripts ](#9-explicación-de-los-scripts-)
10. [Enlace de Figma](#10-enlace-a-figma)
11. [Enlace a la documentación](#11-enlace-a-la-documentación)
12. [Agradecimientos](#12-agradecimientos)
13. [Referencias](#13-referencias)
14. [Despedida](#14-despedida)
15. [Licencias](#15-licencias)
16. [Contacto](#16-contacto)


# 1. Descripción del proyecto

"Lost Castle" es un videojuego de estilo pixel art en 2D que combina elementos de una narrativa atractiva con desafiantes puzzles. La acción se desarrolla en un castillo abandonado lleno de misterios y secretos que el jugador debe descubrir y resolver. A medida que los jugadores avanzan por las diferentes estancias del castillo, encontrarán diversos personajes, objetos y retos que enriquecerán la experiencia de juego y permitirán una inmersión profunda en la historia.

## 2. Justificación

El proyecto "Lost Castle" surge de la necesidad de crear una experiencia de juego que no solo entretenga, sino que también estimule el pensamiento crítico y la resolución de problemas. En un mercado saturado de juegos con gráficos avanzados y tramas simples, "Lost Castle" ofrece una alternativa que destaca por su estilo artístico retro y su enfoque en la narrativa y los puzzles. Este proyecto no solo servirá como mi Trabajo de Fin de Grado, sino que también tiene el potencial de evolucionar y convertirse en un producto completo y comercializable en el futuro.

## 3. Objetivos

Los objetivos principales de este proyecto son:

1. **Desarrollo técnico:** Crear un videojuego funcional utilizando técnicas de programación adecuadas para el desarrollo de juegos en 2D.
2. **Diseño artístico:** Desarrollar un estilo visual coherente y atractivo mediante el uso de pixel art.
3. **Narrativa:** Escribir una historia envolvente que se entrelace con los elementos del juego.
4. **Interacción y jugabilidad:** Diseñar puzzles y desafíos que sean intrigantes y satisfactorios de resolver.
5. **Finalización del TFG:** Presentar un proyecto de calidad que cumpla con los requisitos académicos del Trabajo de Fin de Grado.

## 4. Motivación

La motivación detrás de "Lost Castle" radica en mi pasión por los videojuegos y el diseño creativo. Desde una edad temprana, he sido un entusiasta de los juegos, especialmente aquellos que combinan una buena narrativa con desafíos intelectuales. Este proyecto me permite unir mis intereses personales con mi formación académica, ofreciendo una oportunidad única para aplicar mis conocimientos en programación, diseño y narración de historias.

Además, la creación de "Lost Castle" representa un reto personal y profesional que me permitirá mejorar mis habilidades y adquirir nuevas competencias en el desarrollo de videojuegos. Mi objetivo es que este proyecto no solo sea una demostración de lo aprendido durante mi carrera, sino también un primer paso hacia una futura carrera en la industria del videojuego.

En resumen, "Lost Castle" es un proyecto que aspira a ofrecer una experiencia de juego memorable y enriquecedora, y que marca el inicio de mi camino profesional en el mundo del desarrollo de videojuegos.


## 5. Cómo Jugar

(Versión de Unity: 2020.1.6f1)

- Archivo -> Configuración de Compilación (en orden): Menú -> Escena de Apertura -> Piso00 -> Piso01 -> Piso02 -> Fin

- La ventana ***Juego*** -> Mostrar -> Independiente (1920*1080)

- Activos -> Escenas -> ***Menú***, Ejecutar primero el ***Menú***

- El menú en el juego proporciona botones de operación básicos:

  WASD (caminar)

  Espacio (interactuar)

  B (mochila)

  otros botones se mostrarán en el diálogo del juego

## 6. Lista de Características
### Entorno

- **Niveles:** El juego completo contiene 6 escenas, tres de las cuales son el mapa principal del juego (Piso00, Piso01, Piso02), un menú inicial (Menú), y dos escenas de corte (Escena de Apertura, Fin).
- **Mapas:** El material del mapa utiliza materiales de píxeles gratuitos y se dibuja usando Paleta de Azulejos. El mapa está dividido en 5 capas (Sombra, Suelo, Pared, Muebles, Decoración) para cubrir mejor las imágenes del material.

### Características de Jugabilidad

- **Sistema de Diálogo:** El personaje puede interactuar con objetos interactivos (presionando el botón Espacio). Crea un Panel de Diálogo en el Canvas debajo de cada escena y controla si el panel y el texto se pueden mostrar a través del Script de Manejo de Diálogo.
- **Movimiento del Personaje:** Agrega el movimiento real al objeto del juego, luego agrega la animación al personaje basado en ese movimiento. Usa el bucle de pista de la Animación para reproducir acciones y lograr el efecto dinámico del movimiento.
- **Sistema de Mochila:** Los jugadores pueden recolectar objetos tocando los objetos recolectables en el mundo del juego. Presiona el botón B para abrir la mochila y ver la cantidad de objetos recolectados, y haz clic en el objeto para ver la descripción del objeto.
- **Seguimiento de IA de Monstruos:** El monstruo (el murciélago en el juego) utiliza el algoritmo A* para seguir al jugador a través de la IA, aumentando así la dificultad e interés del juego.
- **Abrir/Cerrar la Puerta:** Puertas dentro del castillo que requieren llaves para abrir. Solo después de obtener ciertas llaves puede el jugador abrir la puerta.
- **Juego de Rompecabezas de Rotación de Foto:** Usa transform.Rotate(0f, 0f, 90f) para hacer clic en la imagen y rotarla. El éxito se determina por si rotation.z es igual a 0. Se puede obtener una pista después de completar el juego de rompecabezas.
- **Juego de Rompecabezas de Arrastrar/Soltar:** Usa Vector3.Distance para realizar el proceso de mosaico y determinar si los objetos son consistentes a través de las coordenadas de la posición inicial y la posición actual. Se puede obtener una pista después de completar el juego de rompecabezas.

### Características No Jugables

- **Escenas de Corte:** Combinando imágenes de fondo de píxeles y funciones de diálogo en la nueva escena para completar la escena de corte de apertura del formato narrativo de la historia. Realiza la escena de corte al final del juego de la misma manera.
- **Cambio de Escena:** Cuando el jugador camina hacia un área específica (es decir, las escaleras), puede presionar la tecla E para entrar en la siguiente escena según la indicación del diálogo.
- **Barra de Progreso de Carga de Escena:** Al entrar en otra capa, habrá una interfaz de carga de escena que muestra el progreso de carga actual y Consejos de Juego. Cuando se carga la escena, al jugador se le pedirá que presione Espacio para entrar en la siguiente escena.
- **Menú de Pausa del Juego:** Los jugadores pueden abrir el menú de pausa del juego haciendo clic en el signo de exclamación en la esquina superior derecha durante el juego. El menú de pausa incluye tres funciones: "Reanudar Juego", "Instrucciones de Operación" y "Ajustar Volumen del Juego".
- **Interfaz de Instrucciones de Operación:** El jugador puede ingresar a la interfaz de instrucciones de operación desde el menú de pausa para ver la guía de operación del jugador.
- **Menú de Inicio del Juego:** El Menú de Inicio del Juego tiene un efecto de desvanecimiento. El jugador hace clic en el botón "nuevo inicio" para entrar en el juego y hace clic en el botón "cancelar" para salir del juego.
- **Diario:** Hay 8 diarios en el juego. Esta es la forma más directa de entender la historia de fondo del juego.

### Audiovisual

- **Cámara:** realiza un movimiento suave de la cámara a través de smoothSpeed*Time.deltaTime y limita el rango máximo (valores x e y) que la cámara puede moverse según el tamaño del mapa.
- **Audio:** Hay tres tipos de música de fondo en el juego, que se encuentran en la escena del Menú, Escena de Apertura y tres Escenas de Piso. Cuando los personajes cambian de escena, hay un efecto de sonido especial.
- **Luz:** Todo el juego se basa en colores oscuros, las velas y antorchas tienen sus propias luces puntuales.


## 7. Guía de instalación 

1. Ir a https://joseluis2003.itch.io/lost-castle o a este qr
![qr](qrcode-generado.png)
2. Ingresar el password vedruna
3. La página web detecta el Sistema Operativo y automáticamente te selecciona el instalador correspondiente
4. Descargar el instalador
5. Ejecutar y jugar

# 8. Guía de uso de Lost Castle

## Primeros pasos

### Menú principal

Al iniciar "Lost Castle", serás recibido por el menú principal. Aquí encontrarás las siguientes opciones:

- **Nuevo Juego:** Comienza una nueva partida desde el principio.
- **Salir:** Cierra el juego.

### Controles

A continuación se detallan los controles predeterminados para jugar "Lost Castle":

#### Teclado

- **Moverse:** WASD
- **Interactuar:** Tecla E y Espacio
- **Abrir inventario:** Tecla B
- **Menú de pausa:** Icono en la parte superior derecha

#### Gamepad

- **Moverse:** Joystick izquierdo

## Desarrollo del juego

### Exploración

El castillo está dividido en varias estancias que deberás explorar para avanzar en la historia. Usa los controles para moverte por el entorno, interactuar con objetos y resolver puzzles que encontrarás a lo largo del camino.

### Puzzles

Los puzzles son una parte central de "Lost Castle". Cada puzzle debe ser resuelto para conseguir las llaves y avanzar a la siguiente área. 
### Inventario

El inventario te permite gestionar los objetos que encuentras durante tu aventura. Accede a él con la tecla B.

- Ver todos los objetos recolectados.

## Consejos y trucos

- **Explora todo:** No dejes ninguna habitación sin explorar; podrías encontrar objetos útiles y pistas importantes.
- **Experimenta:** No dudes en probar diferentes combinaciones de objetos y acciones para resolver puzzles.

## 9. Explicación de los Scripts 

## 1. CameraController

### Descripción

El script `CameraController` es responsable de controlar el movimiento de la cámara en el juego "Lost Castle". Su función principal es hacer que la cámara siga al jugador de manera suave y mantener la vista dentro de unos límites específicos para garantizar que el jugador no vea fuera del área de juego.

### Funcionalidad

1. **Seguimiento del Jugador:**
   - El script encuentra el objeto del jugador usando la etiqueta "Player" y obtiene su componente de transformación (`Transform`).
   - En cada actualización tardía del cuadro (`LateUpdate`), la cámara ajusta su posición para seguir la del jugador.

2. **Movimiento Suave:**
   - En lugar de seguir al jugador instantáneamente, la cámara se mueve suavemente hacia la posición del jugador utilizando la función `Vector3.Lerp`. Esto crea un efecto de seguimiento más fluido y natural.

3. **Límites de Movimiento:**
   - Para evitar que la cámara muestre áreas fuera del diseño del nivel, el script impone límites en las coordenadas X e Y. Estos límites (`minX`, `maxX`, `minY`, `maxY`) se utilizan para restringir la posición de la cámara mediante la función `Mathf.Clamp`.

### Parámetros

- `smoothSpeed`: La velocidad con la que la cámara se ajusta a la posición del jugador. Un valor más alto resulta en un seguimiento más rápido.
- `minX`, `maxX`, `minY`, `maxY`: Coordenadas que definen los límites dentro de los cuales la cámara puede moverse. Estos deben ajustarse según el diseño del nivel para asegurar que la cámara no muestre áreas no deseadas.

## 2. DialogueManager
### Descripción

El script `DialogueManager` es responsable de gestionar los diálogos en el juego "Lost Castle". Permite mostrar y ocultar un cuadro de diálogo cuando el jugador interactúa con ciertos objetos o personajes dentro del juego.

### Funcionalidad

1. **Variables y Componentes:**
   - `isEntered`: Variable booleana que indica si el jugador ha entrado en el área de activación del diálogo.
   - `dialogueBox`: Objeto de UI que representa el cuadro de diálogo en pantalla.
   - `dialogueText`: Componente de texto dentro del cuadro de diálogo donde se muestra el texto del diálogo.
   - `dialogue`: Texto del diálogo que se mostrará cuando el cuadro de diálogo esté activo. Este puede ser configurado en el inspector de Unity utilizando el atributo `TextArea` para permitir la edición de múltiples líneas.

2. **Detección de Entrada y Salida:**
   - `OnTriggerEnter2D`: Se activa cuando el jugador entra en el área de activación (colisionador). Si el objeto que entra tiene la etiqueta "Player", `isEntered` se establece en `true`.
   - `OnTriggerExit2D`: Se activa cuando el jugador sale del área de activación. Si el objeto que sale tiene la etiqueta "Player", `isEntered` se establece en `false` y el cuadro de diálogo se oculta.

3. **Actualización y Control del Diálogo:**
   - `Update`: En cada cuadro del juego, se verifica si el jugador está en el área de activación (`isEntered`) y si ha presionado la tecla de espacio. Si ambas condiciones se cumplen, el script alterna la visibilidad del cuadro de diálogo. Si el cuadro de diálogo ya está activo, se oculta; de lo contrario, se muestra y se actualiza el texto del diálogo.
## 3. EnemyGFX
### Descripción

El script `EnemyGFX` se encarga de gestionar la orientación gráfica de los enemigos en el juego "Lost Castle". Asegura que los enemigos miren en la dirección en la que se están moviendo, proporcionando una representación visual coherente con su movimiento.

### Funcionalidad

1. **Variables y Componentes:**
   - `aiPath`: Este es un componente del sistema Pathfinding que proporciona información sobre la trayectoria deseada del enemigo. El script utiliza `aiPath` para determinar la dirección del movimiento del enemigo.

2. **Actualización de la Orientación:**
   - `Update`: En cada cuadro del juego, el script verifica la velocidad deseada en el eje x (`desiredVelocity.x`) del `aiPath`. Dependiendo de si el valor es positivo o negativo, ajusta la escala local del enemigo para que se oriente hacia la derecha o la izquierda.
     - Si la velocidad deseada en el eje x es mayor o igual a `0.01`, el enemigo se voltea para mirar hacia la derecha (escalando negativamente en el eje x).
     - Si la velocidad deseada en el eje x es menor o igual a `-0.01`, el enemigo se voltea para mirar hacia la izquierda (escalando positivamente en el eje x).

## 4. EnterDialog
### Descripción

El script `EnterDialog` se encarga de mostrar y ocultar un cuadro de diálogo cuando el jugador entra y sale de una zona específica en el juego "Lost Castle". Esto permite proporcionar información contextual o interactuar con el jugador cuando se acerca a ciertos objetos o áreas del juego.

### Funcionalidad

1. **Variables y Componentes:**
   - `enterDialog`: Un objeto de UI que representa el cuadro de diálogo que se mostrará cuando el jugador entre en la zona de activación. Este objeto debe estar asignado en el inspector de Unity.

2. **Detección de Entrada y Salida:**
   - `OnTriggerEnter2D`: Se activa cuando un objeto con un colisionador entra en el área de activación (colisionador 2D con "Is Trigger" activado). Si el objeto que entra tiene la etiqueta "Player", el cuadro de diálogo (`enterDialog`) se activa y se hace visible.
   - `OnTriggerExit2D`: Se activa cuando un objeto con un colisionador sale del área de activación. Si el objeto que sale tiene la etiqueta "Player", el cuadro de diálogo se desactiva y se oculta.

## 5. EnterNextFloor
### Descripción

El script `EnterNextFloor` se encarga de guardar el progreso del juego, mostrar una pantalla de carga y cambiar de escena cuando el jugador presiona una tecla específica. Esto es útil para gestionar la transición entre diferentes niveles o pisos en el juego "Lost Castle".

### Funcionalidad

1. **Variables y Componentes:**
   - `GameSaveManager`: Objeto que gestiona el guardado del juego. Debe tener un componente `GameSaveManager` asignado.
   - `loadScreen`: Objeto de UI que representa la pantalla de carga.
   - `slider`: Componente de `Slider` que muestra el progreso de carga de la nueva escena.
   - `text`: Componente de `Text` que muestra el porcentaje de progreso de carga.
   - `manager`: Variable para almacenar una referencia al componente `GameSaveManager`.

2. **Cambio de Escena Asíncrono:**
   - `LoadLevel`: Corrutina que gestiona la transición a la nueva escena. Activa la pantalla de carga y actualiza el `slider` y el `text` con el progreso de carga de la escena.
     - Utiliza `SceneManager.LoadSceneAsync` para cargar la siguiente escena de manera asíncrona.
     - El progreso de carga se muestra en el `slider` y en el `text`.
     - Cuando la carga alcanza el 90% (`operation.progress` >= 0.9f), se espera a que el jugador presione la tecla `Space` para activar la nueva escena.

3. **Actualización y Control del Guardado/Carga:**
   - `Update`: En cada cuadro del juego, verifica si el jugador ha presionado la tecla `E`.
     - Si se presiona `E`, el script obtiene el componente `GameSaveManager` del objeto `GameSaveManager`, guarda el progreso del juego y comienza la corrutina `LoadLevel`.

## 6. GameSaveManager
### Descripción

El script `GameSaveManager` se encarga de guardar y cargar el estado del juego en "Lost Castle". Utiliza serialización binaria para almacenar y recuperar datos, permitiendo al jugador continuar desde donde dejó el juego.

### Funcionalidad

1. **Variables y Componentes:**
   - `myInventory`: Referencia al objeto de inventario del jugador que contiene los datos que se guardarán y cargarán.

2. **Guardado del Juego:**
   - `SaveGame`: Método que guarda el estado actual del juego.
     - Verifica si el directorio de guardado existe en `Application.persistentDataPath`. Si no existe, lo crea.
     - Utiliza un `BinaryFormatter` para serializar los datos del inventario en formato JSON.
     - Crea un archivo `inventory.txt` en el directorio de guardado y escribe los datos serializados en él.

3. **Cargado del Juego:**
   - `LoadGame`: Método que carga el estado previamente guardado del juego.
     - Verifica si el archivo `inventory.txt` existe en el directorio de guardado.
     - Si el archivo existe, lo abre y utiliza un `BinaryFormatter` para deserializar los datos JSON, restaurando el estado del inventario.

## 7. Menu
### Descripción

El script `Menu` se encarga de gestionar las funcionalidades del menú de pausa y la configuración del volumen en el juego "Lost Castle". Proporciona métodos para pausar y reanudar el juego, así como para ajustar el volumen del audio.

### Funcionalidad

1. **Variables y Componentes:**
   - `pauseMenu`: Un objeto de UI que representa el menú de pausa. Este objeto se activa cuando el juego está en pausa y se desactiva cuando el juego se reanuda.
   - `audioMixer`: Un `AudioMixer` de Unity que controla el volumen general del juego.

2. **Gestión del Juego en Pausa:**
   - `PauseGame`: Método que pausa el juego.
     - Activa el objeto `pauseMenu` para mostrar el menú de pausa.
     - Detiene el tiempo del juego configurando `Time.timeScale` a `0f`.
   - `ResumeGame`: Método que reanuda el juego.
     - Desactiva el objeto `pauseMenu` para ocultar el menú de pausa.
     - Restablece el tiempo del juego configurando `Time.timeScale` a `1f`.

3. **Control de Volumen:**
   - `SetVolume`: Método que ajusta el volumen del audio.
     - Utiliza el `AudioMixer` para establecer el volumen principal (`MainVolume`) al valor proporcionado.


## 8. Menu1

### Descripción

El script `Menu1` se encarga de gestionar el menú principal, el menú de pausa, las instrucciones y la configuración del volumen en el juego "Lost Castle". Proporciona métodos para iniciar el juego, salir del juego, mostrar y ocultar interfaces de usuario, pausar y reanudar el juego, y ajustar el volumen del audio.

### Funcionalidad

1. **Variables y Componentes:**
   - `pauseMenu`: Un objeto de UI que representa el menú de pausa.
   - `InstructionDialog`: Un objeto de UI que muestra las instrucciones del juego.
   - `audioMixer`: Un `AudioMixer` de Unity que controla el volumen general del juego.

2. **Gestión del Menú Principal:**
   - `PlayGame`: Método que carga la siguiente escena, iniciando el juego.
     - Utiliza `SceneManager.LoadScene` para cargar la siguiente escena en la build.
   - `QuitGame`: Método que cierra la aplicación del juego.
     - Utiliza `Application.Quit` para cerrar el juego.
   - `UIEnable`: Método que habilita un componente de UI específico en el menú principal.
     - Busca y activa el objeto `Canvas/MainMenu/UI`.

3. **Gestión del Menú de Pausa:**
   - `PauseGame`: Método que pausa el juego.
     - Activa el objeto `pauseMenu` y detiene el tiempo del juego configurando `Time.timeScale` a `0f`.
   - `ResumeGame`: Método que reanuda el juego.
     - Desactiva el objeto `pauseMenu` y restablece el tiempo del juego configurando `Time.timeScale` a `1f`.

4. **Control de Volumen:**
   - `SetVolume`: Método que ajusta el volumen del audio.
     - Utiliza el `AudioMixer` para establecer el volumen principal (`MainVolume`) al valor proporcionado.

5. **Gestión de Instrucciones:**
   - `OpenInstr`: Método que muestra el cuadro de diálogo de instrucciones.
     - Activa el objeto `InstructionDialog` y desactiva el `pauseMenu`.
   - `CloseInstr`: Método que oculta el cuadro de diálogo de instrucciones.
     - Desactiva el objeto `InstructionDialog` y activa el `pauseMenu`.

## 9. OpenDoor2

### Descripción

El script `OpenDoor2` se encarga de abrir y cerrar una puerta en el juego "Lost Castle" cuando el jugador presiona una tecla específica. Utiliza un `Animator` para controlar la animación de la puerta y detecta si el jugador está cerca de la puerta.

### Funcionalidad

1. **Variables y Componentes:**
   - `anim`: Referencia al componente `Animator` del objeto padre, que controla la animación de la puerta.
   - `InDoor`: Booleano que indica si el jugador está cerca de la puerta. Inicialmente es `true`.
   - `isOpen`: Booleano que indica si la puerta está abierta o cerrada.

2. **Inicialización:**
   - `Start`: Método que se ejecuta al inicio del juego.
     - Obtiene el componente `Animator` del objeto padre y lo asigna a `anim`.

3. **Actualización de Entrada del Jugador:**
   - `Update`: Método que se ejecuta en cada frame.
     - Verifica si el jugador presiona la tecla `V` y si `InDoor` es `true`.
     - Alterna el estado de `isOpen` entre `true` y `false`.
     - Configura el parámetro `Door3Open` del `Animator` con el valor de `isOpen`.

4. **Detección de Colisiones:**
   - `OnTriggerEnter2D`: Método que se ejecuta cuando un objeto entra en el colisionador 2D del objeto con este script.
     - Verifica si el objeto colisionante tiene la etiqueta "Player".
     - Si es así, establece `InDoor` en `true`.

## 10. OpenDoor3

### Descripción

El script `OpenDoor3` se encarga de abrir y cerrar una puerta en el juego "Lost Castle" cuando el jugador presiona una tecla específica. Utiliza un `Animator` para controlar la animación de la puerta y detecta si el jugador está cerca de la puerta.

### Funcionalidad

1. **Variables y Componentes:**
   - `anim`: Referencia al componente `Animator` del objeto padre, que controla la animación de la puerta.
   - `InDoor`: Booleano que indica si el jugador está cerca de la puerta. Inicialmente es `true`.
   - `isOpen`: Booleano que indica si la puerta está abierta o cerrada.

2. **Inicialización:**
   - `Start`: Método que se ejecuta al inicio del juego.
     - Obtiene el componente `Animator` del objeto padre y lo asigna a `anim`.

3. **Actualización de Entrada del Jugador:**
   - `Update`: Método que se ejecuta en cada frame.
     - Verifica si el jugador presiona la tecla `N` y si `InDoor` es `true`.
     - Alterna el estado de `isOpen` entre `true` y `false`.
     - Configura el parámetro `Door3Open` del `Animator` con el valor de `isOpen`.

4. **Detección de Colisiones:**
   - `OnTriggerEnter2D`: Método que se ejecuta cuando un objeto entra en el colisionador 2D del objeto con este script.
     - Verifica si el objeto colisionante tiene la etiqueta "Player".
     - Si es así, establece `InDoor` en `true`.

   
## 11. OpenF1D1

### Descripción

El script `OpenF1D1` se encarga de abrir y cerrar una puerta en el juego "Lost Castle" cuando el jugador presiona una tecla específica. Utiliza un `Animator` para controlar la animación de la puerta y detecta si el jugador está cerca de la puerta.

### Funcionalidad

1. **Variables y Componentes:**
   - `anim`: Referencia al componente `Animator` del objeto padre, que controla la animación de la puerta.
   - `InDoor`: Booleano que indica si el jugador está cerca de la puerta. Inicialmente es `true`.
   - `isOpen`: Booleano que indica si la puerta está abierta o cerrada.

2. **Inicialización:**
   - `Start`: Método que se ejecuta al inicio del juego.
     - Obtiene el componente `Animator` del objeto padre y lo asigna a `anim`.

3. **Actualización de Entrada del Jugador:**
   - `Update`: Método que se ejecuta en cada frame.
     - Verifica si el jugador presiona la tecla `L` y si `InDoor` es `true`.
     - Alterna el estado de `isOpen` entre `true` y `false`.
     - Configura el parámetro `F1D1Open` del `Animator` con el valor de `isOpen`.

4. **Detección de Colisiones:**
   - `OnTriggerEnter2D`: Método que se ejecuta cuando un objeto entra en el colisionador 2D del objeto con este script.
     - Verifica si el objeto colisionante tiene la etiqueta "Player".
     - Si es así, establece `InDoor` en `true`.

## 12. OpenF1D2
### Descripción

El script `OpenF1D2` se encarga de abrir y cerrar una puerta en el juego "Lost Castle" cuando el jugador presiona una tecla específica. Utiliza un `Animator` para controlar la animación de la puerta y detecta si el jugador está cerca de la puerta.

### Funcionalidad

1. **Variables y Componentes:**
   - `anim`: Referencia al componente `Animator` del objeto padre, que controla la animación de la puerta.
   - `InDoor`: Booleano que indica si el jugador está cerca de la puerta. Inicialmente es `true`.
   - `isOpen`: Booleano que indica si la puerta está abierta o cerrada.

2. **Inicialización:**
   - `Start`: Método que se ejecuta al inicio del juego.
     - Obtiene el componente `Animator` del objeto padre y lo asigna a `anim`.

3. **Actualización de Entrada del Jugador:**
   - `Update`: Método que se ejecuta en cada frame.
     - Verifica si el jugador presiona la tecla `J` y si `InDoor` es `true`.
     - Alterna el estado de `isOpen` entre `true` y `false`.
     - Configura el parámetro `F1D2Open` del `Animator` con el valor de `isOpen`.

4. **Detección de Colisiones:**
   - `OnTriggerEnter2D`: Método que se ejecuta cuando un objeto entra en el colisionador 2D del objeto con este script.
     - Verifica si el objeto colisionante tiene la etiqueta "Player".
     - Si es así, establece `InDoor` en `true`.
## 13. UIManager


El script `UIManager` controla la visibilidad de varios elementos de la interfaz de usuario (UI) relacionados con la narrativa del juego "Lost Castle". Permite mostrar y ocultar cajas de diálogo y activar nuevas partes de la historia cuando el jugador presiona la tecla `Espacio`.

### Funcionalidad

1. **Variables y Componentes:**
   - `story2`: Referencia al objeto de la segunda parte de la historia.
   - `dialogueBox1`: Referencia al primer cuadro de diálogo.
   - `dialogueBox2`: Referencia al segundo cuadro de diálogo.

2. **Inicialización:**
   - `Start`: Método que se ejecuta al inicio del juego.
     - Activa el primer cuadro de diálogo (`dialogueBox1`).

3. **Actualización de Entrada del Jugador:**
   - `Update`: Método que se ejecuta en cada frame.
     - Verifica si el jugador presiona la tecla `Espacio`.
     - Si se presiona la tecla `Espacio`, desactiva el primer cuadro de diálogo (`dialogueBox1`), activa la segunda parte de la historia (`story2`) y activa el segundo cuadro de diálogo (`dialogueBox2`).


## 14. OpenTheDoor

### Descripción

El script `OpenTheDoor` se encarga de abrir y cerrar una puerta en el juego "Lost Castle" cuando el jugador presiona una tecla específica. Utiliza un `Animator` para controlar la animación de la puerta y detecta si el jugador está cerca de la puerta.

### Funcionalidad

1. **Variables y Componentes:**
   - `anim`: Referencia al componente `Animator` del objeto padre, que controla la animación de la puerta.
   - `InDoor`: Booleano que indica si el jugador está cerca de la puerta. Inicialmente es `true`.
   - `isOpen`: Booleano que indica si la puerta está abierta o cerrada.

2. **Inicialización:**
   - `Start`: Método que se ejecuta al inicio del juego.
     - Obtiene el componente `Animator` del objeto padre y lo asigna a `anim`.

3. **Actualización de Entrada del Jugador:**
   - `Update`: Método que se ejecuta en cada frame.
     - Verifica si el jugador presiona la tecla `C` y si `InDoor` es `true`.
     - Alterna el estado de `isOpen` entre `true` y `false`.
     - Configura el parámetro `Open` del `Animator` con el valor de `isOpen`.

4. **Detección de Colisiones:**
   - `OnTriggerEnter2D`: Método que se ejecuta cuando un objeto entra en el colisionador 2D del objeto con este script.
     - Verifica si el objeto colisionante tiene la etiqueta "Player".
     - Si es así, establece `InDoor` en `true`.

## 15. Puzzle Mona Lisa

### Descripción

El script `PhotoGameControl` maneja la lógica del puzzle de la Mona Lisa  dentro de "Lost Castle". Este Puzzlese activa cuando el jugador entra en una zona específica y presiona una tecla. Si todas las fotos están correctamente alineadas, el jugador gana y se muestra un panel de llave.

### Funcionalidad

1. **Variables y Componentes:**
   - `isEntered`: Booleano que indica si el jugador ha entrado en la zona del mini-juego.
   - `pictures`: Array de transformaciones que representa las fotos en el mini-juego.
   - `photoPanel`: Referencia al objeto del panel de fotos.
   - `keyPanel`: Referencia al objeto del panel de llave.
   - `youWin`: Booleano estático que indica si el jugador ha ganado el mini-juego.

2. **Inicialización:**
   - `Start`: Método que se ejecuta al inicio del juego.
     - Inicializa `youWin` a `false`.

3. **Detección de Colisiones:**
   - `OnTriggerEnter2D`: Método que se ejecuta cuando un objeto entra en el colisionador 2D del objeto con este script.
     - Verifica si el objeto colisionante tiene la etiqueta "Player".
     - Si es así, establece `isEntered` en `true`.
   - `OnTriggerExit2D`: Método que se ejecuta cuando un objeto sale del colisionador 2D del objeto con este script.
     - Verifica si el objeto colisionante tiene la etiqueta "Player".
     - Si es así, establece `isEntered` en `false` y desactiva los paneles de fotos y llave.

4. **Actualización de Entrada del Jugador:**
   - `Update`: Método que se ejecuta en cada frame.
     - Verifica si `isEntered` es `true` y si el jugador presiona la tecla `E`.
     - Activa el `photoPanel`.
     - Comprueba si todas las fotos están correctamente alineadas (sin rotación).
     - Si todas las fotos están alineadas, establece `youWin` en `true`, desactiva el `photoPanel` y activa el `keyPanel`.


## 16. Script Rotación de las imágenes del puzzle

### Descripción

El script `TouchRotate` permite al jugador rotar imágenes en el puzzle de la Mona Lisa dentro de "Lost Castle" al hacer clic sobre ellos.
### Funcionalidad

1. **Rotación de Objetos:**
   - `OnMouseDown`: Método que se ejecuta cuando el jugador hace clic sobre el objeto.
     - Verifica si el mini-juego de fotos no ha sido ganado (`PhotoGameControl.youWin` es `false`).
     - Si no ha sido ganado, rota el objeto 90 grados en el eje Z.


## 17. PlayerMovement

### Descripción

El script `PlayerMovement` controla el movimiento del jugador en el juego "Lost Castle". Permite al jugador moverse en el plano horizontal y vertical utilizando las teclas de dirección o WASD. También gestiona la animación del personaje mientras se mueve y la apertura y cierre de la bolsa de objetos.

### Funcionalidad

1. **Variables y Componentes:**
   - `moveSpeed`: Velocidad de movimiento del jugador.
   - `rb`: Referencia al componente `Rigidbody2D` del jugador.
   - `animator`: Referencia al componente `Animator` del jugador.
   - `Bag`: Referencia al objeto de la bolsa de objetos.
   - `isOpen`: Booleano que indica si la bolsa de objetos está abierta o cerrada.
   - `movement`: Vector que representa la dirección del movimiento del jugador.

2. **Inicialización:**
   - `Start`: Método que se ejecuta al inicio del juego.
     - Inicializa las referencias a `animator` y `rb`.

3. **Control de Movimiento:**
   - `Update`: Método que se ejecuta en cada frame.
     - Lee la entrada del jugador para determinar la dirección de movimiento.
     - Actualiza la animación del personaje según la dirección del movimiento.
     - Llama al método `MoveCharacter()` para mover al jugador.

4. **Movimiento del Personaje:**
   - `MoveCharacter`: Método que mueve al jugador.
     - Utiliza el componente `Rigidbody2D` para mover al jugador en la dirección especificada.

5. **Apertura/Cierre de la Bolsa de Objetos:**
   - `OpenBag`: Método que gestiona la apertura y cierre de la bolsa de objetos.
     - Detecta si el jugador presiona la tecla `B`.
     - Alterna el estado de `isOpen` y activa/desactiva el objeto `Bag` correspondiente.

## 18. ReturnNextFloor

### Descripción

El script `ReturnNextFloor` maneja el cambio de escena para retroceder al piso anterior en el juego "Lost Castle". Cuando el jugador presiona una tecla específica (`E`), se guarda el progreso del juego, se activa una pantalla de carga y se carga la escena del piso anterior. Una vez que la carga está completa, el jugador puede continuar presionando la tecla `Espacio` para activar la escena.

### Funcionalidad

1. **Variables y Componentes:**
   - `GameSaveManager`: Referencia al objeto del administrador de guardado de juego.
   - `loadScreen`: Referencia al objeto de la pantalla de carga.
   - `slider`: Referencia al objeto del control deslizante de la pantalla de carga.
   - `text`: Referencia al objeto de texto que muestra el progreso de carga.
   - `manager`: Referencia al administrador de guardado de juego.

2. **Cambio de Escena:**
   - `LoadLevel`: Método que realiza el cambio de escena.
     - Activa la pantalla de carga.
     - Carga de forma asíncrona la escena del piso anterior.
     - Mientras la carga está en progreso, actualiza el progreso en el control deslizante y el texto.
     - Cuando la carga está completa, muestra un mensaje para indicar al jugador que puede continuar presionando la tecla `Espacio` para activar la escena.

3. **Guardado y Carga de Juego:**
   - `Update`: Método que se ejecuta en cada frame.
     - Detecta si el jugador presiona la tecla `E`.
     - Guarda el progreso del juego.
     - Inicia la carga de la escena del piso anterior.
     - Carga el progreso del juego.

## 19. ToFloor01

### Descripción

El script `ToFloor01` maneja la transición al primer piso del juego "Lost Castle". Cuando el jugador entra en un área específica y colisiona con un objeto que tiene este script adjunto, se carga la escena del primer piso (`Floor01`).

### Funcionalidad

1. **Variables y Componentes:**
   - `isEntered`: Booleano que indica si el jugador ha entrado en el área del primer piso.

2. **Transición de Escena:**
   - `OnTriggerEnter2D`: Método que se ejecuta cuando un objeto entra en el colisionador 2D del objeto con este script.
     - Verifica si el objeto colisionante tiene la etiqueta "Player".
     - Si es así, establece `isEntered` en `true`.
     - Carga la escena del primer piso (`Floor01`).


## 20. ToFloor02

### Descripción

El script `ToFloor02` maneja la transición al segundo piso del juego "Lost Castle". Cuando el jugador entra en un área específica y colisiona con un objeto que tiene este script adjunto, se carga la escena del segundo piso (`Floor02`).

### Funcionalidad

1. **Transición de Escena:**
   - `OnTriggerEnter2D`: Método que se ejecuta cuando un objeto entra en el colisionador 2D del objeto con este script.
     - Verifica si el objeto colisionante tiene la etiqueta "Player".
     - Si es así, carga la escena del segundo piso (`Floor02`).

## 10. Enlace a figma

[Mira el diseño de Lost Castle en Figma](https://www.figma.com/design/dYTAnHdQozYcXNY9amti7B/Figma-Lost-Castle?node-id=0-1&t=cTlfWsVvwWQkLqly-1)

## 11. Enlace a la Documentación
[Enlace a la documentación](./TFG.docx)

## 12. Agradecimientos
Agradezco la ayuda a mi tutora María Fernanda Hoyuela de la Cueva por su esfuerzo y dedicación en que alcanzara el mejor trabajo posible, sin su apoyo, colaboración y tutoría durante este largo proyecto no habría sido capaz de alcanzar lo que he logrado hoy.

También quiero agradecer a toda mi familia por el apoyo mostrado durante este tiempo, han sido meses complicados y han estado ahí todos los días apoyándome y ayudándome siempre que lo necesitaba, sin ellos no habría llegado donde estoy a día de hoy.

## 13. Referencias 

## Assets Store

1. [Assets 1](https://assetstore.unity.com/packages/2d/gui/fantasy-wooden-gui-free-103811)
2. [Assets 2](https://assetstore.unity.com/packages/2d/characters/pixel-adventure-2-155418)
3. [Assets 3](https://assetstore.unity.com/packages/2d/textures-materials/tiles/pixel-2d-castle-tileset-135397)
4. [Assets 4](https://assetstore.unity.com/packages/2d/gui/simple-fantasy-gui-99451)
5. [Assets 5](https://assetstore.unity.com/packages/2d/characters/tiny-rpg-forest-114685)

## 14. Despedida
Quisiera concluir este readme expresando mi más sincero agradecimiento a todos aquellos que han contribuido de una u otra manera en la realización de este proyecto. Este Trabajo de Final de Grado no solo ha sido un desafío académico, sino también una oportunidad invaluable para mi desarrollo profesional y personal.
Agradezco profundamente a mis profesores y tutores por su orientación y apoyo constante, así como a mis compañeros por su colaboración y camaradería durante este viaje. Igualmente, deseo destacar el respaldo de mi familia y amigos, quienes me han motivado a seguir adelante en los momentos más difíciles.
Este proyecto me ha permitido aplicar los conocimientos adquiridos a lo largo de mi formación y explorar nuevas áreas del desarrollo de videojuegos. Espero que el resultado de mi esfuerzo no solo cumpla con las expectativas académicas, sino que también sirva como base para futuros desarrollos y proyectos en mi carrera profesional.
Con esta despedida, cierro un capítulo importante de mi vida académica, pero con la certeza de que es solo el comienzo de una carrera llena de desafíos y oportunidades en el apasionante mundo de los videojuegos.
Gracias a todos por ser parte de este viaje.
Atentamente,
José Luis González Álamo

## 15. Licencias

Este proyecto está licenciado bajo la MIT License

## 16. Contacto

Para cualquier consulta o sugerencia, puedes contactarme a través de:
- **Correo Electrónico**: joseluisgonzalezalamo@gmail.com


¡Disfruta de tu aventura en "Lost Castle" y buena suerte desentrañando los misterios del castillo abandonado!







