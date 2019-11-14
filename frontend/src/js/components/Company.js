export default function Company(companies) {
    return `
    ${companies
        .map(company => {
            return `
                <section class="company">
                    <img src=${company.image} id="compIMG"></img>
                    <h3>${company.title}</h3>
                    <h5>Location: ${company.location}</h5>
                    <input class="company" type="hidden" value="${company.id}">
                    <button class="edit-company">Edit</button>
                    <button class="delete-company">Delete</button>
                </section>
            `;
        })
    .join("")}

    <section class='compAdd'>
        <input class='add-company_title' type='text' placeholder="Add A New Company">
        <input class='add-company_location' type='text' placeholder="Add Company's Location">
        <button class='add-company'>Submit</button>
    </section>
    `;
}