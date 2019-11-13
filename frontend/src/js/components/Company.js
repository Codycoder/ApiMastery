export default function Company(companies) {
    return `
    ${companies
        .map(company => {
            return `
                <section>
                    <img src=${company.image} id="compIMG"></img>
                    <h3>${company.title}</h3>
                    <h4>${company.location}</h4>
                    <input class="company" type="hidden" value="${company.id}">
                    <button class="edit-company_submit">Edit</button>
                    <button class="delete-company_submit">Delete</button>
                </section>
            `;
        })
    .join("")}

    <section class='add-company'>
        <input class='add-company_name' type='text' placeholder='Add A New Profession'>
        <button class='add-company_submit'>Submit</button>
    </section>
    `;
}