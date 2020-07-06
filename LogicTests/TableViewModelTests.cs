using MathMultiplicationTables.ViewModels;
using NUnit.Framework;

namespace LogicTests
{
    public class TableViewModelTests
    {
        public TableViewModel tableViewModel;
        [SetUp]
        public void Setup()        {
            
        }

        [Test]
        public void ViewModel_answered_is_0()
        {
            //Arrange
            tableViewModel = new TableViewModel(5);

            //Act


            //Assert
            Assert.AreEqual(tableViewModel.answered, 0);
            
        }

        [Test]
        public void ViewModel_correct_is_0()
        {
            //Arrange
            tableViewModel = new TableViewModel(5);

            //Act


            //Assert
            Assert.AreEqual(tableViewModel.correct, 0);

        }

        [Test]
        public void ViewModel_wrong_is_0()
        {
            //Arrange
            tableViewModel = new TableViewModel(5);

            //Act


            //Assert
            Assert.AreEqual(tableViewModel.wrong, 0);

        }

        [Test]
        public void ViewModel_totalQuestions_is_3()
        {
            //Arrange
            tableViewModel = new TableViewModel(5);

            //Act


            //Assert
            Assert.AreEqual(tableViewModel.totalQuestions, 3);

        }

        [Test]
        public void ViewModel_questions_is_not_null()
        {
            //Arrange
            tableViewModel = new TableViewModel(5);

            //Act


            //Assert
            Assert.IsNotNull(tableViewModel.questions);

        }
    }
}