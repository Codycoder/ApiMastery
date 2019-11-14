export default function CompanyCharacter(company){
    return `
    <section>
    <h3>Company ${company.title}</h3>
    <img class="compIMG" src= ${company.image}></img>
    </section>
    ${company.characters
    .map(character => {
        return `
        <section class="character">
        <img src=${character.image} id="charIMG"></img>
        <h3>${character.name}</h3>
        <h5>First Appearance: ${character.game}</h5>
        <h5>Ability: ${character.ability}</h5>
        <input class="character_id" type="hidden" value="${character.id}">
        </section>
`;
    })
    .join("")}
    `
};