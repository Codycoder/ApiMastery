export default function Character(characters) {
    return `
    ${characters
        .map(character => {
            return `
            <section class="character">
                    <img src=${character.image} class="charIMG"></img>
                    <h3>${character.name}</h3>
                    <h5>First Appearance: ${character.game}</h5>
                    <h5>Ability: ${character.ability}</h5>
                    <input class="character_id" type="hidden" value="${character.id}">
                    <button class="edit-character">Edit</button>
                    <button class="delete-character">Delete</button>
                </section>
            `;
        })
    .join("")}

    <section class="charAdd">
        <input class='add-character_name' id="border" type='text' placeholder="Add A New Character">
        <input class='add-character_game' id="border" type='text' placeholder="Add Character's Game">
        <select class='addcharactercompany' id="border" name='company' placeholder="Add A New Company">
        <option value="1">Nintendo</option>
        <option value="2">Sega</option>
        </select>
        <input class='add-character_ability' id="border" type='text' placeholder="Add Character's Ability">
        <button class='add-character'>Submit</button>
    </section>
    `;
}