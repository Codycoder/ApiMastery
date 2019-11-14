export default function EditCharacter(characterEdit) {
    return `
        <section class="main=editCharacter">
        <img src=${characterEdit.image}></img>
        <h3>${characterEdit.name}</h3>
        <h4>${characterEdit.game}</h4>
        <h4>${characterEdit.ability}</h4>
        </section>  
        
        <section class='update-character'>
        <input class='update-character_name' type='text' value="${characterEdit.name}">
        <input class='update-character_game' type='text' value="${characterEdit.game}">
        <select class='updatecharactercompany' id="border" name='company' placeholder="Add A New Company">
        <option value="1">Nintendo</option>
        <option value="2">Sega</option>
        </select>

        <input class='update-character_ability' type='text' value="${characterEdit.ability}">
        <button class='update-character_submit'>Save Changes</button>
        <input class='update-character_id' type='hidden' value="${characterEdit.id}">
        </section>
        `;
}