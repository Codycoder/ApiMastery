export default function EditCompany(companyEdit) {
    return `
        <section class="main=editCompany">
        <h3>${companyEdit.title}</h3>
        </section>  
        
        <section class='update-company'>
        <input class='update-company_title' type='text' value="${companyEdit.title}">
        <input class='update-company_location' type='text' value="${companyEdit.location}">
        <button class='update-company_submit'>Save Changes</button>
        <input class='update-company_id' type='hidden' value="${companyEdit.id}">
        </section>
        `;
}