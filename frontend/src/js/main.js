import Character from "./components/Character"
// import companyid from "./components/Company"
import Home from "./components/Home"
import Header from "./components/Header"
import Footer from "./components/Footer"
import displayCharacter from "./CharacterFunction"
import displayCompany from "./CompanyFunction"

// import apiActions from "./api/apiActions"
// import EditCharacter from "./components/EditCharacter"
// import EditCompany from "./components/EditCompany"

export default () => {
    pageBuild();
}

function pageBuild(){
    header();
    footer();
    home();
    characterAction();
    companyAction();
    // characterColor();
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

// function characterColor(){
//     const speed = rgb(24, 58, 207);
//     const jump = rgb(180, 53, 6);
//     if  (Character.companyid = 2){
//         charIMG.style.border = ".25rem solid rgb(24, 58, 207)";
//     }
//     else {
//         document.getElementById("#charIMG").style.border = ".25rem solid rgb(180, 53, 6)";
//     }
//     Character(characters.characterColor.border-color(speed))
//         border: .25rem solid var(speed);
// border-color(speed)
    
//     border-color: speed;

//     else
//     charIMG{
//         border: .25rem solid var(jump);
//     }
// }
function characterAction(){
    displayCharacter()
}

function companyAction(){
    displayCompany()
}