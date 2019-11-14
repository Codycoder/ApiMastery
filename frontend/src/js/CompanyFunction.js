import Company from "./components/Company"
import EditCompany from "./components/EditCompany"
import apiActions from "./api/apiActions"
import CompanyCharacters from "./components/CompanyCharacters"


export default () => {
    displayCompany()
}

function displayCompany(){
    const compButton = document.querySelector("#companyButton");
    compButton.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44363/api/company", companies => {
            document.querySelector("#app").innerHTML = Company(companies);
            console.log(companies);
        });
    });

    const app = document.querySelector("#app");
    app.addEventListener("click", function(){
        if(event.target.classList.contains("compIMG")){
            const companyid = event.target.parentElement.querySelector(
                ".company_id").value;
            apiActions.getRequest(`https://localhost:44363/api/company/${companyid}`, company=>{
                document.querySelector("#app").innerHTML = CompanyCharacters(company);
                console.log(company);
            })
        }
    })
    app.addEventListener("click", function(){
    if(event.target.classList.contains("add-company")){
        const addCompany = event.target.parentElement.querySelector(
            ".add-company_title").value;
    
        console.log(addCompany);
        apiActions.postRequest("https://localhost:44363/api/company", 
        {
            title: addCompany,
        },
        companies => {
            console.log(companies);
            document.querySelector("#app").innerHTML = Company(companies);
        })
    }
});
app.addEventListener("click",function(){
    if(event.target.classList.contains("delete-company")){
        const compid = event.target.parentElement.querySelector(
            ".company_id").value;
            console.log("delete" + compid)
            apiActions.deleteRequest(`https://localhost:44363/api/company/${compid}`,
            companies => {
                app.innerHTML = Company(companies);

            })
    }
});

app.addEventListener("click",function(){
    if(event.target.classList.contains("edit-company")){
        const compid = event.target.parentElement.querySelector(
            ".company_id").value;
            console.log("edit" + compid)
            apiActions.getRequest(`https://localhost:44363/api/company/${compid}`,
            companyEdit => {
                app.innerHTML = EditCompany(companyEdit);

            })
        
    }
});

app.addEventListener("click", function(){
    if(event.target.classList.contains("update-company_submit")){
        const compid= event.target.parentElement.querySelector(
            ".update-company_id").value;
        const updateCompany = event.target.parentElement.querySelector(
            ".update-company_title").value;
        const updateCompanyLocation = event.target.parentElement.querySelector(
            ".update-company_location").value;
            
        const updateCompanyImage = ""
    
        console.log(updateCompany);
        const companydata = 
        {
            id: compid,
            title: updateCompany,
            location: updateCompanyLocation,
            image: updateCompanyImage
        }
        apiActions.putRequest(`https://localhost:44363/api/company/${compid}`,
        companydata,
        companies => {
            console.log(companies);
            document.querySelector("#app").innerHTML = Company(companies);

        })
    }
});


}
