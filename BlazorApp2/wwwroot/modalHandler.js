// wwwroot/js/modalHandler.js

let bootstrapModalInstances = {}; // Objeto para almacenar las instancias de los modales

window.modalHandler = {
    // Función para obtener o crear la instancia del modal de Bootstrap
    getModalInstance: (elementId) => {
        const modalElement = document.getElementById(elementId);
        if (!modalElement) {
            console.error(`Modal element with ID '${elementId}' not found.`);
            return null;
        }

        if (!bootstrapModalInstances[elementId]) {
            bootstrapModalInstances[elementId] = new bootstrap.Modal(modalElement);
        }
        return bootstrapModalInstances[elementId];
    },

    // Función para mostrar el modal
    showModal: (elementId) => {
        const modalInstance = window.modalHandler.getModalInstance(elementId);
        if (modalInstance) {
            modalInstance.show();
        }
    },

    // Función para ocultar el modal
    hideModal: (elementId) => {
        const modalInstance = window.modalHandler.getModalInstance(elementId);
        if (modalInstance) {
            modalInstance.hide();
        }
    }
};