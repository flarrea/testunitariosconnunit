# TEST UNITARIOS CON NUNIT

######################################################################################

<p align="justify">Demostración de test unitario con el framework NUnit en una aplicación de consola con C#..</p>

<p align="justify">El presente ejemplo demuestra cómo podemos realizar test unitarios con el Framework NUnit en una aplicación de consola en VS2017.</p>

<p align="justify">Los mismos principios son aplicables a una solución asp.net core o asp.net standar.</p>



Identificar los escenarios posibles</br>

Cada Método tiene tres partes (Convención triple A)</br>

//Arrange</br>

*Inicializamos nuestros objetos, preparamos el objeto que queremos testear se crea una instacia de la clase que vamos a probar</br>

*Debemos agregar la referencia al proyecto principal</br>

//Act</br>

*Donce actua el objeto, donde llamamos al método para testearlo</br>

//Assert</br>

*Se verifica que el resultado es correcto</br>


Instalar paquetes de NUnit, desde Package Manager Console</br>

PM> install-package NUnit -Version 3.11.0</br>

PM> install-package NUnit3TestAdapter -Version 3.11.0</br>


Cuando hay un solo escenario usamos Add_WhenCalled_ReturnTheSumOfArguments()</br>

SubirSueldo_WhenCalled_ReturnNewSalaryOfArguments()</br>
