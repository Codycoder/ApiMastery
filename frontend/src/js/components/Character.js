export default function Character(characters) {
    return `
    <ul>
    ${characters
        .map(character => {
            return `
                <li id="character">
                    <img src=${character.image}></img>
                    <h3>${character.name}</h3>
                    <h4>${character.game}</h4>
                    <h4>${character.ability}</h4>
                    <input class="character_id" type="hidden" value="${character.id}">
                    <button class="edit-character_submit">Edit</button>
                    <button class="delete-character_submit">Delete</button>
                    </li>    
            `;
        })
    .join("")}
    </ul>

    <section class='add-character'>
        <input class='add-character_name' type='text' placeholder='Add A New Character'>
        <input class='add-character_game' type='text' placeholder='Add Character's Game'>
        <input class='add-character_ability' type='text' placeholder='Add Character's Ability'>
        <button class='add-character_submit'>Submit</button>
    </section>
    `;
}