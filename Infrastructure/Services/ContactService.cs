namespace Infrastructure.Services;
using Domain.Entities;
using Npgsql;
using Dapper;

public class ContactService
{

 private string _connectionString = "Server=127.0.0.1;Port=5432;Database=contactdb;User Id=postgres;Password=admin;";
public ContactService()
{
    
}

public List<Contact> GetContact()
{
    using (var connection = new NpgsqlConnection(_connectionString) ){
        var sql = "select * from contacts order by id;";
        var result= connection.Query<Contact>(sql);
        return result.ToList();
    }
}

public bool AddContact(Contact contact){
    using (var connection = new NpgsqlConnection(_connectionString)){
        var sql = $"insert into contacts(name,address,telephone) values ('{contact.Name}','{contact.Address}',{contact.Telephone});";
      var inserted=connection.Execute(sql);
      if(inserted>0) return true;
      else return false;
    }
}

public bool UpdateContact(Contact contact){
    using (var connection=new NpgsqlConnection(_connectionString)){
        var sql=$"update contacts set name = '{contact.Name}',address = '{contact.Address}',telephone = {contact.Telephone} where id={contact.Id};";
        var ubdated=connection.Execute(sql);
        if(ubdated>0) return true;
        else return false;
    }
}
public bool DeleteContact(int id)
{
    using (var connection = new NpgsqlConnection(_connectionString)){
        var sql=$"delete from contacts where id={id};";
        var deleted=connection.Execute(sql);
        if(deleted>0) return true;
        else return false;
    }
}
public List<Contact> GetByName(string name){
   using(var connection = new NpgsqlConnection(_connectionString)){
    var sql=$"select * from contacts where name='{name}'  order by id;";
    var result=connection.Query<Contact>(sql);
    return result.ToList();
   }
}
}
