# SimulacionDeIsla
Trabajo práctico de la universidad en la que se nos pide mostrar el progreso de una isla redimensionable, la cual posee gatos, ratones y quesos.

Consigna: 

Se desea modelar un caso hipotético de población de roedores en una isla con el fin de evaluar su
factibilidad de vida.

Se parte de considerar que la isla tiene una superficie rectangular, que permite a los roedores
desplazarse en ella con el objetivo de buscar alimento y/o otros roedores.

El alimento que hay en la isla es queso, el cual se encuentra distribuido sobre ella aleatoriamente. La
cantidad de queso y la cantidad de roedores es seleccionada al momento de iniciar la simulación.

Según las características del modelo de comportamiento el ratón puede comer dos veces en un día. El
ratón come solo una porción de queso a la vez y las raciones distribuidas constan de 2 porciones.

En la simulación se producen incrementos de tiempo dados en intervalos que llamaremos pasos. Cada
diez pasos se considera transcurrido un día completo.

Por cada paso de tiempo, un ratón puede desplazarse o quedarse quieto. Si cuando se desplaza
encuentra queso, entonces come una porción.

Necesariamente debe comer cada 2 días o de lo contrario muere de inanición.

Cuando un ratón avanza, lo hace entre 1 y 3 posiciones en direcciones aleatorias (siempre en línea recta).
Solo come el queso en caso de caer en la misma posición.

Si el ratón, en su desplazamiento va más allá del área delimitada de la isla, cae al agua y muere.
El modelo puede presentar roedores de un solo sexo o de ambos. Si dos ratones de diferente sexo se
encuentran, en la misma posición, se reproducen por lo que aparecen entre 2 y 6 más (luego de 10
intervalos). Debido a esto, la cantidad de raciones de queso se incrementa en un factor igual a la cantidad
de ratones que nacieron dividido 2.

Si al momento de crear las nuevas raciones de queso ya había queso en ese lugar de la isla, la cantidad
de queso se incrementa.

Otro modelo de simulación de interés es uno basado en los principios anteriores, pero donde aparecen
predadores (gatos). En principio, debido a que los gatos le temen al agua, nunca se acercan a la orilla de
la isla y es por esto que no pueden morir ahogados, en el único caso en el cual un gato puede morir es si
no consigue alimento. Los gatos se alimentan de los ratones y necesitan comer uno cada 4 días. Al igual
que el caso de los ratones, avanzan libremente con el mismo comportamiento, pero no pueden 


