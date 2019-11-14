using ApiMastery.Controllers;
using ApiMastery.Models;
using ApiMastery.Repository;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;


namespace ApiMastery.Tests
{
    public class CharacterControllerTests
    {

        private CharacterController underTest;
        IRepository<Character> characterRepo;

        public CharacterControllerTests()
        {
            characterRepo = Substitute.For<IRepository<Character>>();
            underTest = new CharacterController(characterRepo);
        }

        [Fact]
        public void Get_Returns_List_of_Characters()
        {
            var expectedCharacters = new List<Character>()
            {
                new Character("Name", "Game", "Ability", 1, "Image"),
                new Character("Name", "Game", "Ability", 2, "Image")
        };
            characterRepo.GetAll().Returns(expectedCharacters);

            var result = underTest.Get();

            Assert.Equal(expectedCharacters, result.ToList());
        }

        [Fact]
        public void Post_Creates_New_Character()
        {
            var newCharacter = new Character("Name", "Game", "Ability", 1, "Image");
            var characterList = new List<Character>();

            characterRepo.When(t => t.Create(newCharacter))
                .Do(t => characterList.Add(newCharacter));

            characterRepo.GetAll().Returns(characterList);

            var result = underTest.Post(newCharacter);

            Assert.Contains(newCharacter, result);
        }

        [Fact]
        public void Delete_Removes_Character()
        {
            var characterId = 1;
            var deletedCharacter = new Character("Name", "Game", "Ability", 1, "Image");
            var characterList = new List<Character>()
            {
                deletedCharacter,
                new Character("Name", "Game", "Ability", 1, "Image")
        };

            characterRepo.GetById(characterId).Returns(deletedCharacter);
            characterRepo.When(d => d.Delete(deletedCharacter))
                .Do(d => characterList.Remove(deletedCharacter));
            characterRepo.GetAll().Returns(characterList);

            var result = underTest.Delete(characterId);

            Assert.DoesNotContain(deletedCharacter, result); /*Does not work in all cases*/
            //Assert.All(result, item => Assert.Contains("Second item", item.Name));
        }

        [Fact]
        public void Put_Updates_Character()
        {
            var originalCharacter = new Character("Name", "Game", "Ability", 1, "Image"); ;
            var expectedCharacter = new List<Character>()
            {
                originalCharacter
            };
            var updatedCharacter = new Character("Name", "Game", "Ability", 1, "Image");

            characterRepo.When(t => characterRepo.Update(updatedCharacter))
                .Do(Callback.First(t => expectedCharacter.Remove(originalCharacter))
                .Then(t => expectedCharacter.Add(updatedCharacter)));
            characterRepo.GetAll().Returns(expectedCharacter);

            var result = underTest.Put(updatedCharacter);

            // Assert.Equal(expectedTodos, result.ToList());
            Assert.All(result, item => Assert.Contains("Updated item", item.Name));
        }

    }
}
