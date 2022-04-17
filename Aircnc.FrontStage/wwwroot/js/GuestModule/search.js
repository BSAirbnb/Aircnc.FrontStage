
//const bootstrap = require("../../bootstrap/js/bootstrap");

//手機版地圖切換(list to map)
//#region
let btnswitchmap = document.querySelector('#btn-switch-map-list')
let roomlist = document.querySelector('.room-list')
let mapcontainer = document.querySelector('.map-container')

btnswitchmap.addEventListener('click',toRoomList)

function toRoomList(event){
    let target = event.target;
    target.innerHTML = '房源列表';
    target.removeEventListener('click',toRoomList);
    target.addEventListener('click',toMap);
    roomlist.classList.add('d-none');
    roomlist.classList.add('d-md-block');
    mapcontainer.classList.remove('d-none');
    mapcontainer.classList.remove('d-md-block');
}
//#endregion
//手機版地圖切換(map to list)
//#region
function toMap(event){
    let target = event.target;
    target.innerHTML = '地圖';
    target.removeEventListener('click',toMap);
    target.addEventListener('click',toRoomList);
    mapcontainer.classList.add('d-none');
    mapcontainer.classList.add('d-md-block');
    roomlist.classList.remove('d-none');
    roomlist.classList.remove('d-md-block');
}
//#endregion

window.onload = function () {
    initMap();
}

var locations = JSON.parse(@Html.Raw((string)ViewData["Locations"]));
console.log(locations)

// Initialize and add the map
function initMap() {
    // The location of Uluru
    const uluru = { lat: 23.8906, lng: 121.0082 };
    // The map, centered at Uluru
    const map = new google.maps.Map(document.getElementById("map"), {
    zoom: 4,
    center: uluru,
    });
    // The marker, positioned at Uluru
    const marker = new google.maps.Marker({
    position: uluru,
    map: map,
    });
    
    }

//advenceSearch
let navSearch = new Object();
let adSearchVM = new Object();

//每晚預算
//#region
const priceModal = new bootstrap.Modal(document.getElementById('priceModal'));
const minPrice = document.getElementById('minPrice');
const maxPrice = document.getElementById('maxPrice');
const btnpriceClear = document.getElementById('priceClear');
const btnpriceSave = document.getElementById('priceSave');
const priceError = document.getElementById('priceError');
btnpriceClear.addEventListener('click', function () {
    minPrice.value='';
    maxPrice.value = '';
    adSearchVM.minPrice = '';
    adSearchVM.maxPrice = '';
});
btnpriceSave.addEventListener('click', function () {
    if (parseInt(minPrice.value) > parseInt(maxPrice.value)) {
        priceError.classList.remove('invisible');
        priceError.classList.add('visible');
    }
    else {
        adSearchVM.minPrice = parseInt(minPrice.value);
        adSearchVM.maxPrice = parseInt(maxPrice.value);
        priceModal.hide();
    }
    
});
//#endregion
//房源類型
//#region
const houseTypeModal = new bootstrap.Modal(document.getElementById('houseTypeModal'));
const houseTypeClear = document.getElementById('houseTypeClear');
const houseTypeSave = document.getElementById('houseTypeSave');
houseTypeClear.addEventListener('click', function () {
    let checkboxes = document.querySelectorAll('input[name="housetype"]:checked');
    checkboxes.forEach((checkbox) => { checkbox.checked = false });
    let values = [];
    adSearchVM.houseTypes = values;
});
houseTypeSave.addEventListener('click', function () {
    let values = [];
    adSearchVM.houseTypes = values;
    let checkboxes = document.querySelectorAll('input[name="housetype"]:checked');
    checkboxes.forEach((checkbox) => { values.push(checkbox.value) });
    adSearchVM.houseTypes = values;
    houseTypeModal.hide();
})
//#endregion
//房間類型
//#region
const roomTypeModal = new bootstrap.Modal(document.getElementById('roomTypeModal'));
const roomTypeClear = document.getElementById('roomTypeClear');
const roomTypeSave = document.getElementById('roomTypeSave');
roomTypeClear.addEventListener('click', function () {
    let checkboxes = document.querySelectorAll('input[name="roomtype"]:checked');
    checkboxes.forEach((checkbox) => { checkbox.checked = false });
    let values = [];
    adSearchVM.roomTypes = values;
});
roomTypeSave.addEventListener('click', function () {
    let values = [];
    adSearchVM.roomTypes = values;
    let checkboxes = document.querySelectorAll('input[name="roomtype"]:checked');
    checkboxes.forEach((checkbox) => { values.push(checkbox.value) });
    adSearchVM.roomTypes = values;
    roomTypeModal.hide();
})
//#endregion
//臥室床位浴室
//#region
const bedroomModal = new bootstrap.Modal(document.getElementById('bedroomModal'));
const bedroomClear = document.getElementById('bedroomClear');
const bedroomSave = document.getElementById('bedroomSave');
const bedCount = document.getElementById('bed');
const bedroomCount = document.getElementById('bedroom');
const bathroomCount = document.getElementById('bathroom');
const minusBed = document.getElementById('minus-bed');
const minusBedroom = document.getElementById('minus-bedroom');
const minusBathroom = document.getElementById('minus-bathroom');
const addBed = document.getElementById('add-bed');
const addBedroom = document.getElementById('add-bedroom');
const addBathroom = document.getElementById('add-bathroom');
//bed加減
minusBed.addEventListener('click', function () {
    if (parseInt(bedCount.innerText) > 0) {
        bedCount.innerText = parseInt(bedCount.innerText) - 1;
    }
})

addBed.addEventListener('click', function () {
    if (parseInt(bedCount.innerText) < 100) {
        bedCount.innerText = parseInt(bedCount.innerText) + 1;
    }
})
//bedroom加減
minusBedroom.addEventListener('click', function () {
    if (parseInt(bedroomCount.innerText) > 0) {
        bedroomCount.innerText = parseInt(bedroomCount.innerText) - 1;
    }
})

addBedroom.addEventListener('click', function () {
    if (parseInt(bedroomCount.innerText) < 100) {
        bedroomCount.innerText = parseInt(bedroomCount.innerText) + 1;
    }
})
//bathroom加減
minusBathroom.addEventListener('click', function () {
    if (parseInt(bathroomCount.innerText) > 0) {
        bathroomCount.innerText = parseInt(bathroomCount.innerText) - 1;
    }
})

addBathroom.addEventListener('click', function () {
    if (parseInt(bathroomCount.innerText) < 100) {
        bathroomCount.innerText = parseInt(bathroomCount.innerText) + 1;
    }
})

bedroomClear.addEventListener('click', function () {
    bedCount.innerText = "0";
    bedroomCount.innerText = "0";
    bathroomCount.innerText = "0";
});
bedroomSave.addEventListener('click', function () {
    adSearchVM.bedCount = parseInt(bedCount.innerText);
    adSearchVM.roomCount = parseInt(bedroomCount.innerText);
    adSearchVM.bathroomCount = parseInt(bathroomCount.innerText);
    bedroomModal.hide();
    //console.log(adSearchVM)
})
//#endregion
//RoomService and advanceSearchBtn
//#region
const btnAdSearch = document.getElementById('btnAdSearch');


btnAdSearch.addEventListener('click', function () {
    let values = [];
    adSearchVM.roomServiceLabels = values;
    let checkboxes = document.querySelectorAll('input[name="roomService"]:checked');
    checkboxes.forEach((checkbox) => { values.push(checkbox.value) });
    adSearchVM.roomServiceLabels = values;

    console.log(wantToGo)
    navSearch.Location = wantToGo.value;
    navSearch.StartDate = startDate.value;
    navSearch.EndDate = endDate.value;
    navSearch.NumberOfGuests = parseInt(guestNumbers.value);

    let searchVM = {
        NavSearch: navSearch,
        AdSearch: adSearchVM
    }
    //searchVM.NavSearch = navSearch;
    //searchVM.AdSearch = adSearchVM;
    
    let request = {
        searchVM: searchVM
    }
    fetch("/Search/Search", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(request)
    })

})
//#endregion
