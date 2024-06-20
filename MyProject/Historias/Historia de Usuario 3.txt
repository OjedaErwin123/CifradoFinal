Historia de Usuario No. 3

Manejo de letras y caracteres especiales

Como usuario, necesito que el programa maneje correctamente mayúsculas, minúsculas y caracteres especiales para que el resultado del cifrado y descifrado sea preciso

#Descripción
Esta historia de usuario asegura que el programa pueda manejar de manera adecuada las mayúsculas, minúsculas y caracteres especiales durante el proceso de cifrado y descifrado con el algoritmo César.

#Criterios de Aceptación
1.Manejo de Mayúsculas y Minúsculas
 o El programa debe mantener las mayúsculas y minúsculas en su forma original después del cifrado y descifrado.
 o Las letras deben desplazarse correctamente sin cambiar su caso.
2.Manejo de Caracteres Especiales
 o Los caracteres especiales (como puntuación y espacios) deben mantenerse sin cambios en su posición original.
 o El desplazamiento solo debe afectar a las letras del alfabeto.

#Prioridad
Media

#Estimación
3 Dias

#Notas/Tareas Adicionales
 • Implementar la lógica para diferenciar entre mayúsculas, minúsculas y caracteres especiales.
 • Asegurar que los caracteres especiales no se vean afectados por el desplazamiento.

#Discusiones
1.Decisión sobre el Tratamiento de Caracteres
 o Se decidió que los caracteres especiales no deben ser desplazados.
 o Justificación: Mantiene la integridad del texto original en cuanto a puntuación y formato.
