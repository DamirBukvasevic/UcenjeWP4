import { HttpService } from "./HttpService"


async function get(){
    return await HttpService.get('/Smjer')
    .then((odgovor)=>{
        //console.table(odgovor.data);
        return odgovor.data;
    })
    .catch((e)=>{console.error(e)})
}

async function obrisi(sifra){
    return await HttpService.delete('/Smjer/' + sifra)
    .then((odgovor) =>{
        //console.log(e);
        return {greska: false, poruka: odgovor.data.poruka}
    })
    .catch((e)=>{
        //console.log(e);
        return {greska: true, poruka: 'Smjer se ne može obrisati'}
    })
}

async function promjena(smjer){
    return await HttpService.post('/Smjer/' , smjer)
    .then((odgovor) =>{
        //console.log(e);
        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{
        //console.log(e);
        return {greska: true, poruka: 'Smjer se može dodati'}
    })
}

export default{
    get,
    obrisi,
    promjena
}