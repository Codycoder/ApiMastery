import Character from "./components/Character"
import Company from "./components/Company"
import Home from "./components/Home"
import Header from "./components/Header"
import Footer from "./components/Footer"
import apiActions from "./api/apiActions"

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
}
    // const app = document.querySelector("#app");
    // app.addEventListener("click", function(){
    // if(event.target.classList.contains("add-character_submit")){
    //     const addCharacter = event.target.parentElement.querySelector(
    //         ".add-character_name").value;
    //     const addCharacterGame = event.target.parentElement.querySelector(
    //         ".add-character_game").value;
    //     const addCharacterAbility = event.target.parentElement.querySelector(
    //         ".add-character_ability").value;
    //     const addCharacterImage = ""
    
    //     console.log(addCharacter);
    //     apiActions.postRequest("https://localhost:44363/api/character", 
    //     {
    //         name: addCharacter,
    //         game: addCharacterGame,
    //         ability: addCharacterAbility,
    //         image: addCharacterImage
    //     },
    //     characters => {
    //         console.log(characters);
    //         document.querySelector("#app").innerHTML = Character(characters);
    //     }
    // }
    // });


function displayCompany(){
    const compButton = document.querySelector("#companyButton");
    compButton.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44363/api/company", companies => {
            document.querySelector("#app").innerHTML = Company(companies);
            console.log(companies);
        });
    });
}
//     const app = document.querySelector("#app");
//     app.addEventListener("click", function(){
//     if(event.target.classList.contains("add-profession_submit")){
//         const addProfession = event.target.parentElement.querySelector(
//             ".add-profession_title").value;
    
//         console.log(addProfession);
//         apiActions.postRequest("https://localhost:44363/api/profession", 
//         {
//             title: addProfession,
//         },
//         professions => {
//             console.log(professions);
//             document.querySelector("#app").innerHTML = Profession(profession);
//         }
//     }
// });

