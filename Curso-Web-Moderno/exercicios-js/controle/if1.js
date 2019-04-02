function boaNoticia(nota){
    if(nota>=7){
        console.log('Passou!')
    }
}

boaNoticia(8)

function seForVerdadeEuFalo(valor){
    if(valor){
        console.log('É verdadeiro ...' + valor)
    }
}

seForVerdadeEuFalo()
seForVerdadeEuFalo(null)
seForVerdadeEuFalo(true)