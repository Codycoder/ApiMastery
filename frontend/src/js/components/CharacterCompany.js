export default function CharacterCompany(character){
    return `
    <section class="character">
    <h3>Company ${character.name}</h3>
    <img class="charIMG" src= ${character.image}></img>
    </section>

    <section class="company">
        <img src=${character.company.image} class="compIMG"></img>
        <h3>${character.company.title}</h3>
        <h5>Location: ${character.company.location}</h5>
        <input class="company_id" type="hidden" value="${character.company.id}">
    </section>
    `};