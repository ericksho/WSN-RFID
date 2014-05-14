class CreatePermisos < ActiveRecord::Migration
  def change
    create_table :permisos do |t|
      t.string :titulo

      t.timestamps
    end
  end
end
