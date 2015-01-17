namespace Cars.Tests.JustMock
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using System.Collections.Generic;
    using Cars.Models;


    [TestClass]
    public class CarsControllerTests
    {
        private ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            : this(new MoqCarsRepository())
        {
        }

        public CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A4", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        [TestMethod]
        public void SearchCarsByPatternReturnsBMWsAsSpecifiedInMockedRepository()
        {

            var cars = (ICollection<Car>)this.GetModel(() => this.controller.Search("Opel"));

            Assert.AreEqual(2, cars.Count);
            Assert.AreEqual("BMW", cars.First().Make);
            Assert.IsTrue(cars.First().Model.StartsWith("3"));
        }

        [TestMethod]
        public void SortCarsByMakeShouldReturnWhatIsSpecifiedInTheMockedRepository()
        {
            var cars = (ICollection<Car>)this.GetModel(() => this.controller.Sort("make"));

            Assert.AreEqual(1, cars.Count);
            Assert.AreEqual("Opel", cars.First().Make);
            Assert.IsTrue(cars.First().Model.StartsWith("A"));
        }

        [TestMethod]
        public void SortCarsByYearShouldReturnWhatIsSpecifiedInTheMockedRepository()
        {
            var cars = (ICollection<Car>)this.GetModel(() => this.controller.Sort("year"));

            Assert.AreEqual(1, cars.Count);
            Assert.AreEqual(2010, cars.First().Year);
            Assert.AreEqual("Opel", cars.First().Make);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void SortCarsByModelShouldThrowAnExceptionDueToUnknownCriteria()
        {
            var cars = (ICollection<Car>)this.GetModel(() => this.controller.Sort("model"));
        }
        //CarsController.Details cannot be tested with throwing an Exception, as the 
        //var car = this.carsData.GetById(id) 
        //always returns a car from the mocked repository


        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}
