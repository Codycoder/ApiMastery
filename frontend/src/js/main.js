import Character from "./components/Character"
import Profession from "./components/Profession"
import Header from "./components/Header"
import Footer from "./components/Footer"
import Character from "./components/Character"
import Profession from "./components/Profession"
import apiActions from "./api/apiActions"

export default () => {
    pageBuild()
}

function pageBuild(){
    header();
    footer();
    displayCharacter();
    displayProfession();
}

function header(){
    const header = document.getElementById("header")
    header.innerHTML = Header()    
}
function footer(){
    const footer = document.getElementById("footer")
    footer.innerHTML = Footer()    
}

function displayCharacter(){
    const characterButton = document.querySelector("");
    characterButton.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44342/api/character", characters => {
            document.querySelector("#app").innerHTML = Character(characters);
            console.log(characters);
        });
    });

    const app = document.querySelector("#app");
    app.addEventListener("click", function(){
    if(event.target.classList.contains("add-character_submit")){
        const addCharacter = event.target.parentElement.querySelector(
            ".add-character_name").value;
        const addCharacterGame = event.target.parentElement.querySelector(
            ".add-character_game").value;
        const addCharacterAbility = event.target.parentElement.querySelector(
            ".add-character_ability").value;
        const addCharacterImage = ""
    
        console.log(addCharacter);
        apiActions.postRequest("https://localhost:44342/api/character", 
        {
            name: addCharacter,
            game: addCharacterGame,
            ability: addCharacterAbility,
            image: addCharacterImage
        },
        characters => {
            console.log(characters);
            document.querySelector("#app").innerHTML = Character(characters);
        }
    }
    });
}

function displayProfession(){
    const professionButton = document.querySelector("");
    professionButton.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44342/api/profession", professions => {
            document.querySelector("#app").innerHTML = Profession(professions);
            console.log(professions);
        });
    });

    const app = document.querySelector("#app");
    app.addEventListener("click", function(){
    if(event.target.classList.contains("add-profession_submit")){
        const addProfession = event.target.parentElement.querySelector(
            ".add-profession_title").value;
    
        console.log(addProfession);
        apiActions.postRequest("https://localhost:44342/api/profession", 
        {
            title: addProfession,
        },
        professions => {
            console.log(professions);
            document.querySelector("#app").innerHTML = Profession(profession);
        }
    }
});
}
