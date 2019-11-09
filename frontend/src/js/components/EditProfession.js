export default function EditProfession(professionEdit) {
    return `
        <section class="main=editProfession">
        <h3>${profession.title}</h3>
        </section>  
        
        <section class='update-profession'>
        <input class='update-profession_title' type='text' value="${characterEdit.name}>
        <button class='update-profession_submit'>Save Changes</button>
        <input class='update-profession_id' type='hidden' value="${characterEDIT.id}">
        </section>
        `;
}