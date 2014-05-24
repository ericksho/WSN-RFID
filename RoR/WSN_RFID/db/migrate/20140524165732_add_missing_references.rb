class AddMissingReferences < ActiveRecord::Migration
  def change
  	add_reference :alertas, :lectura, index:true
  	add_reference :articulos, :tipo, index:true
  	add_reference :atributos, :articulo, index:true
  	add_reference :lecturas, :articulo, index:true
  	add_reference :lecturas, :lector, index:true
  end
end
