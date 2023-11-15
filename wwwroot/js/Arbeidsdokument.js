<!-- kode for søke felt-->

    

document.addEventListener("DOMContentLoaded", function () {
    const searchInput = document.getElementById("searchInput");

    searchInput.addEventListener("input", function () {
        const searchTerm = searchInput.value.toLowerCase();
        søkTable();
        filterTable(searchTerm);
    });

    function søkTable() {
        const tableRows = document.querySelectorAll("tbody tr");
        tableRows.forEach((row) => {
            row.style.display = "";
            row.querySelectorAll("td").forEach((cell) => {
                cell.innerHTML = cell.textContent;
            });
        });
    }

    function filterTable(searchTerm) {
        const tableRows = document.querySelectorAll("tbody tr");
        tableRows.forEach((row) => {
            let hasMatch = false;
            row.querySelectorAll("td").forEach((cell) => {
                const cellText = cell.textContent.toLowerCase();
                if (cellText.includes(searchTerm)) {
                    hasMatch = true;
                    const highlightedText = cellText.replace(new RegExp(searchTerm, "gi"), (match) => {
                        return `<span class="highlight">${match}</span>`;
                    });
                    cell.innerHTML = highlightedText;
                } else {
                    cell.innerHTML = cellText;
                }
            });
            row.style.display = hasMatch ? "" : "none";
        });
    }

    
    
    
});

 