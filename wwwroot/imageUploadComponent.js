////window.showImagePreview = async (imgElementId, imageStream) => {
////    const arrayBuffer = await imageStream.arrayBuffer();
////    const blob = new Blob([arrayBuffer]);
////    const url = URL.createObjectURL(blob);
////    const image = document.getElementById(imageElementId);
////    image.onload = () => {
////        URL.revokeObjectURL(url);
////    }
////    image.src = url;
////}

window.showImagePreview = (inputElem, imgElem) => {
    const url = URL.createObjectURL(inputElem.files[0]);
    imgElem.addEventListener('load', () => URL.revokeObjectURL(url), { once: true });
    imgElem.src = url;
}

window.showImagePreviewFromByteArray = (imageElementRef, byteArray) => {
    const blob = new Blob([byteArray]);
    const url = URL.createObjectURL(blob);
    imageElementRef.onload = () => {
        URL.revokeObjectURL(url);
    }
    imageElementRef.src = url;
}

window.setImageSource = (imgElem, srcStr) => {
    imgElem.src = srcStr;
}

window.setImage = async (imageElementRef, imageStream) => {
    const arrayBuffer = await imageStream.arrayBuffer();
    const blob = new Blob([arrayBuffer]);
    const url = URL.createObjectURL(blob);
    imageElementRef.onload = () => {
        URL.revokeObjectURL(url);
    }
    imageElementRef.src = url;
}