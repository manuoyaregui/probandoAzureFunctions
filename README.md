# probandoAzureFunctions

- Palabras/frases clave
    
    **Triggers:** Corre código cuando un evento ocurre
    
    Sin manejo de Infraestructura
    

Azure Functions es un servicio de Azure que permite ejecutar pequeñas piezas de código (funciones) de forma escalable y sin preocuparse por la infraestructura subyacente. Las funciones pueden ser escritas en varios lenguajes de programación, como C#, Java, JavaScript, Python, etc.

La arquitectura de Azure Functions se basa en el modelo "serverless" o "sin servidor", que significa que el proveedor de la nube se encarga de la administración de la infraestructura subyacente y solo se cobra por el tiempo que la función se ejecuta.

Cuando una función es activada, Azure Functions crea una instancia de un contenedor de ejecución, donde el código de la función es cargado y ejecutado. La función puede ser activada por una variedad de disparadores (triggers) como HTTP, timers, cambios en la base de datos, eventos de IoT, entre otros. Además, las funciones también pueden responder con una variedad de tipos de salida, como JSON, HTML, archivos, entre otros.

Azure Functions también tiene integraciones con otros servicios de Azure como Azure Event Hubs, Azure Blob Storage, Azure Cosmos DB, entre otros, lo que permite a las funciones interactuar con otros servicios en la nube y crear soluciones más avanzadas y completas.

En ****resumen, Azure Functions es un servicio de nube que permite a los desarrolladores crear y ejecutar pequeñas piezas de código de forma escalable y sin preocuparse por la infraestructura subyacente, lo que permite una mayor eficiencia y agilidad en el desarrollo de aplicaciones y soluciones en la nube.

- Triggers
    
    **HTTP Trigger**: Permite desencadenar la función cuando se recibe una petición HTTP. Esto es útil para crear APIs web o para integrar servicios en la nube con aplicaciones existentes.
    
    **Timer Trigger**: Permite desencadenar la función en un intervalo de tiempo determinado. Por ejemplo, se puede configurar para que la función se ejecute cada hora, cada día o cada semana.
    
    **Queue Trigger**: Permite desencadenar la función cuando se añade un mensaje a una cola de Azure Storage. Esto es útil para procesar tareas en segundo plano o para integrar aplicaciones existentes con servicios en la nube.
    
    **Blob Trigger**: Permite desencadenar la función cuando se añade o modifica un archivo en un contenedor de Azure Storage. Esto es útil para procesar archivos de manera automática o para integrar aplicaciones existentes con servicios en la nube.
    
    **Event Hub Trigger**: Permite desencadenar la función cuando se produce un evento en un Event Hub de Azure. Esto es útil para procesar eventos de manera automática o para integrar aplicaciones existentes con servicios en la nube.
