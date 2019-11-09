export default function Profession(professions) {
    return `
    <ul>
    ${professions
        .map(profession => {
            return `
                <li id="profession">
                    <img src=${profession.image}></img>
                    <h3>${profession.name}</h3>
                    <h4>${profession.game}</h4>
                    <h4>${profession.ability}</h4>
                    <input class="profession" type="hidden" value="${profession.id}">
                    <button class="edit-profession_submit">Edit</button>
                    <button class="delete-profession_submit">Delete</button>
                    </li>    
            `;
        })
    .join("")}
    </ul>

    <section class='add-profession'>
        <input class='add-profession_name' type='text' placeholder='Add A New Profession'>
        <button class='add-profession_submit'>Submit</button>
    </section>
    `;
}