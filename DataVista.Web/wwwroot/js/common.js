
export function handleDeleteBtnClick(url, dataTable) {
    const table = document.querySelector("#datatable");

    table.addEventListener("click", (e) => {
        let id = e.target.dataset.deleteId ?? e.target.parentElement.dataset.deleteId;;
        if (id) {
            deleteRecord(`${url}${id}`, dataTable);
        }
    });
}

function deleteRecord(url, dataTable) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then(async (result) => {
        if (result.isConfirmed) {
            try {
                const { success, message } = await fetch(url, { method: 'DELETE' }).then(res => res.json());

                if (success) {
                    dataTable.ajax.reload();
                    toastr.success(message);
                }
                else {
                    toastr.error(message);
                }

            } catch (e) {

                console.error("Network error", e);
            }
        }
    })
}


export function magnifyImg() {
    $(".image-popup").magnificPopup({
        type: "image",
        closeOnContentClick: !0,
        closeBtnInside: !1,
        fixedContentPos: !0,
        mainClass: "mfp-no-margins mfp-with-zoom",
        image: { verticalFit: !0 },
        zoom: { enabled: !0, duration: 300 },
    })
}

export function validateImageSize() {    
    const fileUpload = document.querySelector('#imageInput');
    const fileUploadAr = document.querySelector('#imageInputt');
    const validationMsg = document.querySelector('#imageValidationMsg');
    const validationMsgAr = document.querySelector('#imageValidationMsgAr');
    const submitBtn = document.querySelector('#formSubmitBtn');
    const imageSizeLarge = 800;
    const imageSizeLargeAr = 800;

    const reader = new FileReader();

    fileUpload.addEventListener('change', () => {
        reader.readAsDataURL(fileUpload.files[0]);
        console.log(submitBtn);
        reader.onload = (e) => {
            const image = new Image();
            image.src = e.target.result;
            image.onload = () => {
                if (image.width < imageSizeLarge) {
                    validationMsg.textContent = `Image width should be above ${imageSizeLarge}.`;
                    submitBtn.disabled = true;
                }
                else {
                    validationMsg.textContent = "";
                    submitBtn.disabled = false;
                }
            };
        };
    })



    if (fileUploadAr != undefined) {

        fileUploadAr.addEventListener('change', () => {
            reader.readAsDataURL(fileUploadAr.files[0]);
            console.log(submitBtn);
            reader.onload = (e) => {
                const image = new Image();
                image.src = e.target.result;
                image.onload = () => {
                    if (image.width < imageSizeLargeAr) {
                        validationMsgAr.textContent = `Image width should be above ${imageSizeLargeAr}.`;
                        submitBtn.disabled = true;
                    }
                    else {
                        validationMsg.textContent = "";
                        submitBtn.disabled = false;
                    }
                };
            };
        })
    }

} 