let edit_room_count = document.querySelector('.edit_room_count');
let edit_bed_count = document.querySelector('.edit_bed_count');
let edit_bathroom_count = document.querySelector('.edit_bathroom_count');
let Keyword = document.getElementById('hostList_searchBar');
let wifi = document.getElementById('Wifi');
let Kitchen = document.getElementById('Kitchen');
let TV = document.getElementById('TV');
let Aircon = document.getElementById('Aircon');
let Parking = document.getElementById('Parking');
let Washing = document.getElementById('Washing');
let Online = document.getElementById('Online');
let Offline = document.getElementById('Offline');
let Pending = document.getElementById('Pending');


let form_check_equipment_and_service = document.querySelectorAll(
    '.form_check_equipment_and_service>input'
);

let form_check_roomStatus = document.querySelectorAll(
    '.form_check_roomStatus>input'
);

// 減
function room_minus(minusBtn) {
    var count = document.querySelector('.' + minusBtn);
    if (count.textContent > 0) {
        count.textContent -= 1;
    }
}

// 加
function room_plus(plusBtn) {
    var count = document.querySelector('.' + plusBtn);
    count.textContent = parseInt(count.textContent) + 1;
}

// 清除btn
function edit_clear(clearType) {
    switch (clearType) {
        case 'clear_room':
            edit_room_count.innerHTML = 0;
            edit_bed_count.innerHTML = 0;
            edit_bathroom_count.innerHTML = 0;
            break;
        case 'clear_equipment_and_service':
            form_check_equipment_and_service.forEach((item) =>
                item.checked = false
            );
            break;
        case 'clear_roomStatus':
            form_check_roomStatus.forEach((item) => item.checked = false);
            break;
        default:
            break;
    }
}

function filterBtn(Id) {
    let searchResult = {}
    searchResult.UserId = Id
    //搜尋房源
    searchResult.KeyWord = Keyword.textContent;
    //房間與床鋪
    searchResult.BedCount = parseInt(edit_bed_count.textContent);
    searchResult.BathroomCount = parseInt(edit_bathroom_count.textContent);
    searchResult.RoomCount = parseInt(edit_room_count.textContent);
    //設備與服務
    searchResult.TypeOfLabel = []
    if (Aircon != null && Aircon.checked) {
        searchResult.TypeOfLabel.push(Aircon.value)
    }
    if (Washing != null &&  Washing.checked) {
        searchResult.TypeOfLabel.push(Washing.value)
    }
    if (wifi != null &&  wifi.checked) {
        searchResult.TypeOfLabel.push(wifi.value)
    }
    if (Kitchen != null &&  Kitchen.checked) {
        searchResult.TypeOfLabel.push(Kitchen.value)
    }
    if (Parking != null &&  Parking.checked) {
        searchResult.TypeOfLabel.push(Parking.value)
    }
    if (TV != null &&  TV.checked) {
        searchResult.TypeOfLabel.push(TV.value)
    }
    //房源狀態
    if (Online.checked) {
        searchResult.Status = 1;
    }

    if (Offline.checked) {
        searchResult.Status = 2;
    }

    if (Pending.checked) {
        searchResult.Status = 3;
    }
    //console.log(searchResult)
    //let result = {
    //    hostListSearchDto: searchResult
    //}
    console.log(searchResult)
    hostList_search(searchResult);
   
}


//關鍵字搜尋
function hostList_search(searchResult) {
    fetch("/RoomOwner/HostList", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(searchResult)

    })
        .then(response => response.json())
        .then(jsonData => {
            console.log(jsonData)
             jsonData.forEach(x => {
                 if (x.status == 1)
                {
                     x.status = `<i class="fas fa-hourglass-half"></i>`
                    
                 }

            })
          

                let tbody = document.querySelector('tbody')
            tbody.innerHTML = ''
                
            jsonData.forEach(x => {
            let row = `<tr class="tr_roomlist w-100">

            <td>
                <div class="form-check">
                    <input class="form-check-input" type="checkbox" value="" id="flexCheckChecked" checked>
                </div>
            </td>

            <td class="hostList_room_name">
                <a href="/RoomOwner/HostRoomEditList?roomid=${x.roomId}">
                    <div class="d-flex  host_list_house_img">
                        <img src="">
                        <p class="host_list_house_name">${x.roomName}</p>
                    </div>
                </a>

            </td>

            <td>
                ${x.status}
                ${x.state}
            </td>
            <td><button class="btn">完成</button></td>
            <td><i class="fas fa-check-circle"></i>開</td>
            <td>${x.roomCount}</td>
            <td>${x.bedCount}</td>
            <td>${x.bathroomCount}</td>
            <td>${x.address}</td>
                
            <td>
                ${x.createTime}
            </td>

            </tr>`
            tbody.innerHTML += row
                console.log(row)
                console.log(tbody)

        })
            

        })
}

//let searchResult = {}
////套用btn
//function edit_apply() {

//    searchResult.edit_bed_count

//}
//function HostListSearch(result) {

//    fetch('RoomOwner/HostList', {
//        method: "GET",
//        headers: {
//            "Content-Type": "application/json"
//        },
//        body: JSON.stringify(result)

//    })
//        .then(response => response.json())
//        .then(jsonData => {
//            console.log(jsonData)
//        })

//}
