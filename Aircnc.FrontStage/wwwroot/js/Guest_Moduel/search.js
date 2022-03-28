
// 日曆
//#region 
$(function(){
    $('#datepicker-start').datepicker();
    $('#datepicker-end').datepicker();
});
//#endregion

//抓螢幕高度
let windowHeight = window.innerHeight;
    console.log(windowHeight);

//地圖切換
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
    