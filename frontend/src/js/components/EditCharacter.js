export default function EditCharacter(characterEdit) {
    return `
        <section class="main=editCharacter">
        <img src=${character.image}></img>
        <h3>${character.name}</h3>
        <h4>${character.game}</h4>
        <h4>${character.ability}</h4>
        </section>  
        
        <section class='update-character'>
        <input class='update-character_name' type='text' value="${characterEdit.name}>
        <input class='update-character_game' type='text' value="${characterEdit.game}>
        <input class='update-character_ability' type='text' value="${characterEdit.ability}>
        <button class='update-character_submit'>Save Changes</button>
        <input class='update-character_id' type='hidden' value="${characterEDIT.id}">
        </section>
        `;
}