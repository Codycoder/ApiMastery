export default function Company(companies) {
    return `
    <ul>
    ${companies
        .map(company => {
            return `
                <li id="company">
                    <img src=${company.image}></img>
                    <h3>${company.name}</h3>
                    <h4>${company.game}</h4>
                    <h4>${company.ability}</h4>
                    <input class="company" type="hidden" value="${company.id}">
                    <button class="edit-company_submit">Edit</button>
                    <button class="delete-company_submit">Delete</button>
                    </li>    
            `;
        })
    .join("")}
    </ul>

    <section class='add-company'>
        <input class='add-company_name' type='text' placeholder='Add A New Profession'>
        <button class='add-company_submit'>Submit</button>
    </section>
    `;
}