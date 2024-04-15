export default function MyForm() 
{
  function handleSubmit(e) // pegar valores dos input e transformar em json 
  {
    // Prevent the browser from reloading the page
    e.preventDefault();

    // Read the form data
    const form = e.target;
    const formData = new FormData(form);

    // You can pass formData as a fetch body directly:
    fetch('/some-api', { method: form.method, body: formData });

    // Or you can work with it as a plain object:
    const formJson = Object.fromEntries(formData.entries());
    console.log(formJson);
  }

  return (
    <>
    <h1>Vamos achar o melhor Petshop para você:</h1>
    <form method="post" onSubmit={handleSubmit}>
      <label>
        Digite uma data: <input name="Data"  />  {/* Pedir a data */}        
      </label>
      <hr />

      <label>
        Digite quantidade de cachorro de porte Grande: <input name="QuantCaoGrande"  />
      </label>
      <hr />  

      <label>
        Digite quantidade de cachorro de porte Pequeno: <input name="QuantCaoPequeno"  />
      </label>
      <hr />            
      
      <button type="reset">Reset </button>
      <button type="submit">OK</button>
    </form>
    </>
  );
}