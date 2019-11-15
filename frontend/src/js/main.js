import Home from "./components/Home"
import Header from "./components/Header"
import Footer from "./components/Footer"
import displayCharacter from "./CharacterFunction"
import displayCompany from "./CompanyFunction"


export default () => {
    pageBuild();
}

function pageBuild(){
    header();
    footer();
    home();
    characterAction();
    companyAction();
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

function characterAction(){
    displayCharacter()
}

function companyAction(){
    displayCompany()
}