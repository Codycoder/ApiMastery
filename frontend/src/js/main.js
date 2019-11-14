import Character from "./components/Character"
import Company from "./components/Company"
import Home from "./components/Home"
import Header from "./components/Header"
import Footer from "./components/Footer"
import apiActions from "./api/apiActions"
import EditCharacter from "./components/EditCharacter"
import EditCompany from "./components/EditCompany"

export default () => {
    pageBuild();
}

function pageBuild(){
    header();
    footer();
    home();
    displayCharacter();
    displayCompany();
}

function header(){
    const header = document.getElementById("header")
    header.innerHTML = Header()    
}
function footer(){
    const footer = document.getElementById("footer")
    footer.innerHTML = Footer()    
}

function home(){
    const landing = document.querySelector("#app");
    landing.innerHTML = Home()
    const homeButton = document.querySelector("#homeButton");
    homeButton.addEventListener("click", function(){
    document.querySelector("#app").innerHTML = Home();
    })
}

function displayCharacter(){
    const charButton = document.querySelector("#characterButton");
    charButton.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44363/api/character", character => {
            document.querySelector("#app").innerHTML = Character(character);
            console.log(character);
        });
    });
    const app = document.querySelector("#app");
    app.addEventListener("click", function(){
    if(event.target.classList.contains("add-character")){
        const addCharacter = event.target.parentElement.querySelector(
            ".add-character_name").value;
        const addCharacterGame = event.target.parentElement.querySelector(
            ".add-character_game").value;
            const addcharactercompany = event.target.parentElement.querySelector(
                ".addcharactercompany").value;
            
        const addCharacterAbility = event.target.parentElement.querySelector(
            ".add-character_ability").value;
        const addCharacterImage = ""
    
        console.log(addCharacter);
        apiActions.postRequest("https://localhost:44363/api/character", 
        {
            name: addCharacter,
            game: addCharacterGame,
            companyid: addcharactercompany,
            ability: addCharacterAbility,
            image: addCharacterImage
        },
        characters => {
            console.log(characters);
            document.querySelector("#app").innerHTML = Character(characters);
        })
    }
    });

app.addEventListener("click",function(){
    if(event.target.classList.contains("delete-character")){
        const charid = event.target.parentElement.querySelector(
            ".character_id").value;
            console.log("delete" + charid)
            apiActions.deleteRequest(`https://localhost:44363/api/character/${charid}`,
            characters => {
                app.innerHTML = Character(characters);

            })
        
    }
});

app.addEventListener("click",function(){
    if(event.target.classList.contains("edit-character")){
        const charid = event.target.parentElement.querySelector(
            ".character_id").value;
            console.log("edit" + charid)
            apiActions.getRequest(`https://localhost:44363/api/character/${charid}`,
            characterEdit => {
                app.innerHTML = EditCharacter(characterEdit);

            })
        
    }
});

app.addEventListener("click", function(){
    if(event.target.classList.contains("update-character_submit")){
        const charid= event.target.parentElement.querySelector(
            ".update-character_id").value;
        const updateCharacter = event.target.parentElement.querySelector(
            ".update-character_name").value;
        const updateCharacterGame = event.target.parentElement.querySelector(
            ".update-character_game").value;
            const updatecharactercompany = event.target.parentElement.querySelector(
                ".updatecharactercompany").value;
            
        const updateCharacterAbility = event.target.parentElement.querySelector(
            ".update-character_ability").value;
        const updateCharacterImage = ""
    
        console.log(updateCharacter);
        const characterdata = 
        {
            id: charid,
            name: updateCharacter,
            game: updateCharacterGame,
            companyid: updatecharactercompany,
            ability: updateCharacterAbility,
            image: updateCharacterImage
        }
        apiActions.putRequest(`https://localhost:44363/api/character/${charid}`,
        characterdata,
        characters => {
            console.log(characters);
            document.querySelector("#app").innerHTML = Character(characters);

        })
    }
});

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

}

