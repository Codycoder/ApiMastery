export default function Character(characters) {
    return `
    ${characters
        .map(character => {
            return `
                <section>
                    <img src=${character.image} id="charIMG"></img>
                    <h1>${character.name}</h1>
                    <h3>First Appearance: ${character.game}</h3>
                    <h3>Ability: ${character.ability}</h3>
                    <input class="character_id" type="hidden" value="${character.id}">
                    <button class="edit-character_submit">Edit</button>
                    <button class="delete-character_submit">Delete</button>
                </section>
            `;
        })
    .join("")}

    <section class='add-character'>
        <input class='add-character_name' type='text' placeholder='Add A New Character'>
        <input class='add-character_game' type='text' placeholder='Add Character's Game'>
        <input class='add-character_ability' type='text' placeholder='Add Character's Ability'>
        <button class='add-character_submit'>Submit</button>
    </section>
    `;
}