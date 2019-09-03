using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using DatosEmpleados;

namespace DatosEmpleados.UnitTest
{
    [TestFixture]

    //Indicamos la clase que estamos testeando con la convención nombre de la clase más Tests, "EmpleadoTests"

    public class EmpleadoTests
    {
        [Test]

        //Indicamos el método a testear con la siguiente convención: MethodUnderTest_Scenario_EspectedBehavior()
        //Debemos considerar un test para todos los escenarios posibles de ocurrencia, o caminos de ejecución
        //Cuando hay un solo escenario usamos Method_WhenCalled_ReturnTheSumOfArguments() 

        public void SubirSueldo_WhenCalled_ReturnNewSalaryOfArguments()
        {
            // Arrange: Preparación: Inicializamos los objetos que queremos testear
            //Creamos una instancia de la clase Empleado

            var empleadouno = new Empleado();
            empleadouno.Sueldo = 100;

            // Act: Ejecución: Actuamos sobre el objeto, llamamos el método que vamos a testear "SubirSueldo",
            //luego, le entregamos un argumento, parámetro, en este caso el poncentaje de aumento
            //podemos guardar el resultado en una variable o no

            empleadouno.SubirSueldo(50);

            var result = empleadouno.Sueldo;

            // Assert: Comprobación: Verificamos que el resultado es correcto, debe ser verdadero
            //También podría escribirse:
            //Assert.IsTrue(result);
            //Assert.That(result, Is.True);
            //Assert.That(result ==True);

            Assert.That(result, Is.EqualTo(150));
        }

        //Apartir de aquí agregamos tests para los demas escenarios...


        //Reutilizar la clase empleado, para evitar inicializar un objeto en cada test

        private Empleado _empleadouno; //Creamos un campo privado para usarlo en diferentes pruebas

        //En NUnit tenemos el atributo SetUp, que test runner lo puede llamar antes de ejecutar la prueba
        //y TearDown, después de ejecutar la prueba, se usa para test de integración
        //SetUp
        //TearDown


        [SetUp]
        public void SetUp()
        {
            _empleadouno = new Empleado(); //Inicializamos una nueva instancia de la clase
        }

        [TearDown]
        public void VariableaCero()
        {
            _empleadouno.Sueldo = 100; //Al finalizar el test volverá el sueldo a 100
        }

        [Test]

        public void SubirSueldo_WhenCalledWithInitializadeBefore_ReturnNewSalaryOfArguments()
        {
            // Arrange
            //var empleadouno = new Empleado();

            // Act
            _empleadouno.Sueldo = 100;

            _empleadouno.SubirSueldo(50);

            var result = _empleadouno.Sueldo;

            // Assert
            Assert.That(result, Is.EqualTo(150));
        }

        //Con parámetros
        [Test]
        [TestCase(100, 50, 150)]
        [TestCase(200, 100, 400)]

        public void SubirSueldo_WhenCalledWithParameters_ReturnNewSalaryOfArguments(int a, int b, int expectedResult)
        {
            // Arrange
            //var empleadouno = new Empleado();

            // Act
            _empleadouno.Sueldo = a;

            _empleadouno.SubirSueldo(b);

            var result = _empleadouno.Sueldo;

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        //Ignora test...

        [Test]
        [Ignore("Está imcompleto!")]
        [TestCase(100, 50, 150)]
        [TestCase(200, 100, 400)]

        public void SubirSueldo_WhenCalledDisabled_ReturnNewSalaryOfArguments(int a, int b, int expectedResult)
        {
            // Arrange
            //var empleadouno = new Empleado();

            // Act
            _empleadouno.Sueldo = a;

            _empleadouno.SubirSueldo(b);

            var result = _empleadouno.Sueldo;

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

    }
}
