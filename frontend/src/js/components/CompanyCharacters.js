export default function CompanyCharacter(company){
    return `
    <h3>Company ${company.title}</h3>
    <img src= ${company.image}></img>

    <ul>
    ${company.characters
    .map(character=>{
        return `
        <li>
        <img src= ${character.image}></img>
        <h3>${character.name}</h3>
        <p><input type="hidden" value="${character.id}></p>
        </li> 
        `
    })
.join("")}
</ul>
    `
}