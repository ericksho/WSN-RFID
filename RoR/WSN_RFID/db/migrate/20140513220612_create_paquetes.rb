class CreatePaquetes < ActiveRecord::Migration
  def change
    create_table :paquetes do |t|
      t.string :nombre
      t.string :valores_dez
      t.string :tipo

      t.timestamps
    end
  end
end
