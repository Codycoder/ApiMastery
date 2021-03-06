﻿using ApiMastery.Controllers;
using ApiMastery.Models;
using ApiMastery.Repository;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace ApiMastery.Tests
{
    public class CompanyControllerTests
    {

        private CompanyController underTest;
        IRepository<Company> companyRepo;

        public CompanyControllerTests()
        {
            companyRepo = Substitute.For<IRepository<Company>>();
            underTest = new CompanyController(companyRepo);
        }

        [Fact]
        public void Get_Returns_List_of_Companys()
        {
            var expectedCompanies = new List<Company>()
                {
                    new Company("Title", 1, "Location", "Image", "Color"),
                    new Company("Title", 2, "Location", "Image", "Color")
            };
            companyRepo.GetAll().Returns(expectedCompanies);

            var result = underTest.Get();

            Assert.Equal(expectedCompanies, result.ToList());
        }

        [Fact]
        public void Post_Creates_New_Company()
        {
            var newCompany = new Company("Title", 1, "Location", "Image", "Color");
            var companyList = new List<Company>();

            companyRepo.When(t => t.Create(newCompany))
                .Do(t => companyList.Add(newCompany));

            companyRepo.GetAll().Returns(companyList);

            var result = underTest.Post(newCompany);

            Assert.Contains(newCompany, result);
        }

        [Fact]
        public void Delete_Removes_Company()
        {
            var companyId = 1;
            var deletedCompany = new Company("Title", 1, "Location", "Image", "Color");
            var companyList = new List<Company>()
                {
                    deletedCompany,
                    new Company("Title", 1, "Location", "Image", "Color")
            };

            companyRepo.GetById(companyId).Returns(deletedCompany);
            companyRepo.When(d => d.Delete(deletedCompany))
                .Do(d => companyList.Remove(deletedCompany));
            companyRepo.GetAll().Returns(companyList);

            var result = underTest.Delete(companyId);

            Assert.DoesNotContain(deletedCompany, result); /*Does not work in all cases*/
                                                             //Assert.All(result, item => Assert.Contains("Second item", item.Name));
        }

        [Fact]
        public void Put_Updates_Company()
        {
            var originalCompany = new Company("Title", 1, "Location", "Image", "Color"); ;
            var expectedCompany = new List<Company>()
                {
                    originalCompany
                };
            var updatedCompany = new Company("Title", 1, "Location", "Image", "Color");

            companyRepo.When(t => companyRepo.Update(updatedCompany))
                .Do(Callback.First(t => expectedCompany.Remove(originalCompany))
                .Then(t => expectedCompany.Add(updatedCompany)));
            companyRepo.GetAll().Returns(expectedCompany);

            var result = underTest.Put(updatedCompany);

            // Assert.Equal(expectedTodos, result.ToList());
            Assert.All(result, item => Assert.Contains("Updated item", item.Title));
        }
    }
}


